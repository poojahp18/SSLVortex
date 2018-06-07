using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace SSLVortex
{
    public sealed class ProxyServer
    {
        private static readonly ProxyServer _server = new ProxyServer();

        private static readonly int BUFFER_SIZE = 8192;
        private static readonly char[] semiSplit = new char[] { ';' };
        private static readonly char[] equalSplit = new char[] { '=' };
        private static readonly String[] colonSpaceSplit = new string[] { ": " };
        private static readonly char[] spaceSplit = new char[] { ' ' };
        private static readonly char[] commaSplit = new char[] { ',' };
        private static readonly Regex cookieSplitRegEx = new Regex(@",(?! )");
        
        private static X509Certificate _certificate1;
        private static object _outputLockObj = new object();
        private TcpListener _listener;
        private Thread _listenerThread;
        private Thread _cacheMaintenanceThread;
        public static X509Certificate2 _certificate;
        public IPAddress ListeningIPInterface
        {
            get
            {
                IPAddress addr = IPAddress.Loopback;
                if (ConfigurationManager.AppSettings["ListeningIPInterface"] != null)
                    IPAddress.TryParse(ConfigurationManager.AppSettings["ListeningIPInterface"], out addr);
                return addr;
            }
        }
        public Int32 ListeningPort
        {
            get
            {
                Int32 port = 8081;
                if (ConfigurationManager.AppSettings["ListeningPort"] != null)
                    Int32.TryParse(ConfigurationManager.AppSettings["ListeningPort"], out port);
                return port;
            }
        }
        public X509Certificate2 GetCertificate2()
        {
            return _certificate;
        }
        private ProxyServer()
        {
            _listener = new TcpListener(ListeningIPInterface, ListeningPort);
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        }
        public Boolean DumpHeaders { get; set; }
        public Boolean DumpPostData { get; set; }
        public Boolean DumpResponseData { get; set; }

        public static ProxyServer Server
        {
            get { return _server; }
        }

        public bool Start()
        {
            try
            {
                String certFilePath = String.Empty;
                if (ConfigurationManager.AppSettings["CertificateFile"] != null)
                    certFilePath = ConfigurationManager.AppSettings["CertificateFile"];
                try
                {
                    _certificate = new X509Certificate2(certFilePath, "suraj#13");
                }
                catch (Exception ex)
                {
                    throw new ConfigurationErrorsException(String.Format("Could not create the certificate from file from {0}", certFilePath), ex);
                }
                _listener.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            _listenerThread = new Thread(new ParameterizedThreadStart(Listen));
            _cacheMaintenanceThread = new Thread(new ThreadStart(ProxyCache.CacheMaintenance));

            _listenerThread.Start(_listener);
            _cacheMaintenanceThread.Start();

            return true;
        }

        public void Stop()
        {
            _listener.Stop();
            _listenerThread.Abort();
            _cacheMaintenanceThread.Abort();
            _listenerThread.Join();
            _listenerThread.Join();
        }

        private static void Listen(Object obj)
        {
            TcpListener listener = (TcpListener)obj;
            try
            {
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    while (!ThreadPool.QueueUserWorkItem(new WaitCallback(ProxyServer.ProcessClient), client)) ;
                }
            }
            catch (ThreadAbortException) { }
            catch (SocketException) { }
        }


        private static void ProcessClient(Object obj)
        {
            TcpClient client = (TcpClient)obj;
            try
            {
                DoHttpProcessing(client);
            }
            catch (Exception ex)
            {
                // Send to log
            }
            finally
            {
                client.Close();
            }
        }

        private static void DoHttpProcessing(TcpClient client)
        {
            Stream clientStream = client.GetStream();
            Stream outStream = clientStream;
            SslStream sslStream = null;
            StreamReader clientStreamReader = new StreamReader(clientStream);
            CacheEntry cacheEntry = null;
            MemoryStream cacheStream = null;

            String headline = "", headers = "", body = "",dword="";
            Request req = null;
            Response res = null;
            if (Server.DumpHeaders || Server.DumpPostData || Server.DumpResponseData)
            {
                Monitor.TryEnter(_outputLockObj, TimeSpan.FromMilliseconds(-1.0));
            }

            try
            {
                String httpCmd = clientStreamReader.ReadLine();
                if (String.IsNullOrEmpty(httpCmd))
                {
                    clientStreamReader.Close();
                    clientStream.Close();
                    return;
                }
                String[] splitBuffer = httpCmd.Split(spaceSplit,3);
                String method = splitBuffer[0];
                String remoteUri = splitBuffer[1];
                Version version = new Version(1, 1);

                HttpWebRequest webReq;
                HttpWebResponse response = null;
                //foreach (String ss in splitBuffer)
                //{
                //    MessageBox.Show (ss.ToString());
                //}
                if (splitBuffer[0].ToUpper() == "CONNECT")
                {
                    remoteUri = "https://" + splitBuffer[1];
                    while (!String.IsNullOrEmpty(clientStreamReader.ReadLine())) ;
                    StreamWriter connectStreamWriter = new StreamWriter(clientStream);
                    connectStreamWriter.WriteLine("HTTP/1.0 200 Connection established");
                    connectStreamWriter.WriteLine(String.Format("Timestamp: {0}", DateTime.Now.ToString()));
                    connectStreamWriter.WriteLine("Proxy-agent: VORTEX");
                    connectStreamWriter.WriteLine();
                    connectStreamWriter.Flush();

                    sslStream = new SslStream(clientStream, false);
                    try
                    {
                        sslStream.AuthenticateAsServer(_certificate, false, SslProtocols.Tls | SslProtocols.Ssl3 | SslProtocols.Ssl2, false);
                        
                    }
                    catch (Exception)
                    {
                        sslStream.Close();
                        clientStreamReader.Close();
                        connectStreamWriter.Close();
                        clientStream.Close();
                        return;
                    }
                    clientStream = sslStream;
                    //dword = (sslStream.RemoteCertificate.Subject);
                    clientStreamReader = new StreamReader(sslStream);
                    outStream = sslStream;
                    
                    httpCmd = clientStreamReader.ReadLine();
                    if (String.IsNullOrEmpty(httpCmd))
                    {
                        clientStreamReader.Close();
                        clientStream.Close();
                        sslStream.Close();
                        return;
                    }
                    splitBuffer = httpCmd.Split(spaceSplit, 3);
                    method = splitBuffer[0];
                    remoteUri = remoteUri + splitBuffer[1];
                    //_certificate1 = (X509Certificate)(sslStream.RemoteCertificate);
                }                
                webReq = (HttpWebRequest)HttpWebRequest.Create(remoteUri);
  
                //foreach (X509Certificate cert in webReq.ClientCertificates)
                //{
                //    MessageBox.Show(cert.ToString());
                //}
                webReq.Method = method;
                webReq.ProtocolVersion = version;
                int contentLen = ReadRequestHeaders(clientStreamReader, webReq);
                webReq.Proxy = null;
                webReq.KeepAlive = false;
                webReq.AllowAutoRedirect = false;
                webReq.AutomaticDecompression = DecompressionMethods.None;
                if (Server.DumpHeaders)
                {
                    headline = (String.Format("{0} {1} HTTP/{2}", webReq.Method, webReq.RequestUri.AbsoluteUri, webReq.ProtocolVersion));
                    foreach (String s in webReq.Headers.AllKeys)
                    {
                        headers += (String.Format("{0}: {1}", s, webReq.Headers[s]));
                        headers += "\r\n";
                    }
                    headers += "AddedIN: Req1";
                    headers += "\r\n";
                }
                if (method.ToUpper() == "GET")
                    cacheEntry = ProxyCache.GetData(webReq);
                else if (method.ToUpper() == "POST")
                {
                    char[] postBuffer = new char[contentLen];
                    int bytesRead;
                    int totalBytesRead = 0;
                    StreamWriter sw = new StreamWriter(webReq.GetRequestStream());
                    while (totalBytesRead < contentLen && (bytesRead = clientStreamReader.ReadBlock(postBuffer, 0, contentLen)) > 0)
                    {
                        totalBytesRead += bytesRead;
                        sw.Write(postBuffer, 0, bytesRead);
                        if (ProxyServer.Server.DumpPostData)
                            foreach (char c in postBuffer)
                                body += c;
                    }
                    sw.Close();
                }
                req = new Request(headline, headers, body);
                if (cacheEntry == null)
                {
                    webReq.Timeout = 15000;
                    try
                    {
                        response = (HttpWebResponse)webReq.GetResponse();
                    }
                    catch (WebException webEx)
                    {
                        response = webEx.Response as HttpWebResponse;
                    }
                    if (response != null)
                    {
                        List<Tuple<String, String>> responseHeaders = ProcessResponse(response);
                        //fiddMessageBox.Show(webReq.ClientCertificates.Count.ToString());
                        StreamWriter myResponseWriter = new StreamWriter(outStream);
                        Stream responseStream = response.GetResponseStream();
                        try
                        {
                            String s = String.Format("HTTP/1.0 {0} {1}", (Int32)response.StatusCode, response.StatusDescription);
                            myResponseWriter.WriteLine(s);
                            if (ProxyServer.Server.DumpHeaders)
                                headline = (s);
                            if (responseHeaders != null)
                            {
                                foreach (Tuple<String, String> header in responseHeaders)
                                    myResponseWriter.WriteLine(String.Format("{0}: {1}", header.Item1, header.Item2));
                            }
                            myResponseWriter.WriteLine();
                            myResponseWriter.Flush();

                            foreach (Tuple<String, String> header in responseHeaders)
                            {
                                headers += (String.Format("{0}: {1}", header.Item1, header.Item2));
                                headers += "\r\n";
                            }
                            headers += "AddedIN: Res1";
                            headers += "\r\n";
                            DateTime? expires = null;
                            CacheEntry entry = null;
                            Boolean canCache = (sslStream == null && ProxyCache.CanCache(response.Headers, ref expires));
                            if (canCache)
                            {
                                entry = ProxyCache.MakeEntry(webReq, response, responseHeaders, expires);
                                if (response.ContentLength > 0)
                                    cacheStream = new MemoryStream(entry.ResponseBytes);
                            }
                            Byte[] buffer;
                            if (response.ContentLength > 0)
                                buffer = new Byte[response.ContentLength];
                            else
                                buffer = new Byte[BUFFER_SIZE];
                            int bytesRead;
                            while ((bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                if (cacheStream != null)
                                    cacheStream.Write(buffer, 0, bytesRead);
                                outStream.Write(buffer, 0, bytesRead);
                                if (Server.DumpResponseData)
                                    body = (UTF8Encoding.UTF8.GetString(buffer, 0, bytesRead));
                            }
                            responseStream.Close();
                            if (cacheStream != null)
                            {
                                cacheStream.Flush();
                                cacheStream.Close();
                            }
                            outStream.Flush();
                            if (canCache)
                                ProxyCache.AddData(entry);
                        }
                        catch (Exception ex)
                        {
                            //To log
                        }
                        finally
                        {
                            responseStream.Close();
                            response.Close();
                            myResponseWriter.Close();
                        }
                    }
                }
                else
                {
                    StreamWriter myResponseWriter = new StreamWriter(outStream);
                    try
                    {
                        String s = String.Format("HTTP/1.0 {0} {1}", (Int32)cacheEntry.StatusCode, cacheEntry.StatusDescription);
                        myResponseWriter.WriteLine(s);
                        if (ProxyServer.Server.DumpHeaders)
                            headline = (s);
                        if (cacheEntry.Headers != null)
                        {
                            foreach (Tuple<String, String> header in cacheEntry.Headers)
                                myResponseWriter.WriteLine(String.Format("{0}: {1}", header.Item1, header.Item2));
                        }
                        myResponseWriter.WriteLine();
                        myResponseWriter.Flush();
                        headers = "";
                        foreach (Tuple<String, String> header in cacheEntry.Headers)
                        {
                            headers += (String.Format("{0}: {1}", header.Item1, header.Item2));
                            headers += "\r\n";
                        }
                        headers += "AddedIN: Res2";
                        headers += "\r\n";
                        if (cacheEntry.ResponseBytes != null)
                        {
                            outStream.Write(cacheEntry.ResponseBytes, 0, cacheEntry.ResponseBytes.Length);
                            if (ProxyServer.Server.DumpResponseData)
                                body = (UTF8Encoding.UTF8.GetString(cacheEntry.ResponseBytes));
                        }
                        myResponseWriter.Close();
                    }
                    catch (Exception ex)
                    {
                        //To the log
                    }
                    finally
                    {
                        myResponseWriter.Close();
                    }
                }
                res = new Response(headline, headers, body);
                Storage.Add("", req, res);
            }
            catch (Exception ex)
            {
                //To log
            }
            finally
            {
                if (Server.DumpHeaders || Server.DumpPostData || Server.DumpResponseData)
                {
                    Monitor.Exit(_outputLockObj);
                }
                clientStreamReader.Close();
                clientStream.Close();
                if (sslStream != null)
                    sslStream.Close();
                outStream.Close();
                if (cacheStream != null)
                    cacheStream.Close();
            }
        }
        private static List<Tuple<String, String>> ProcessResponse(HttpWebResponse response)
        {
            String value = null;
            String header = null;
            List<Tuple<String, String>> returnHeaders = new List<Tuple<String, String>>();
            foreach (String s in response.Headers.Keys)
            {
                if (s.ToLower() == "set-cookie")
                {
                    header = s;
                    value = response.Headers[s];
                }
                else
                    returnHeaders.Add(new Tuple<String, String>(s, response.Headers[s]));
            }
            if (!String.IsNullOrWhiteSpace(value))
            {
                response.Headers.Remove(header);
                String[] cookies = cookieSplitRegEx.Split(value);
                foreach (String cookie in cookies)
                    returnHeaders.Add(new Tuple<String, String>("Set-Cookie", cookie));
            }
            returnHeaders.Add(new Tuple<String, String>("X-Proxied-By", "VORTEX"));
            return returnHeaders;
        }
        private static void WriteResponseHeaders(StreamWriter myResponseWriter, List<Tuple<String, String>> headers)
        {
            if (headers != null)
            {
                foreach (Tuple<String, String> header in headers)
                    myResponseWriter.WriteLine(String.Format("{0}: {1}", header.Item1, header.Item2));
            }
            myResponseWriter.WriteLine();
            myResponseWriter.Flush();
            if (Server.DumpHeaders)
                DumpHeaderCollectionToConsole(headers);
        }
        private static void DumpHeaderCollectionToConsole(List<Tuple<String, String>> headers)
        {
            foreach (Tuple<String, String> header in headers)
                Console.WriteLine(String.Format("{0}: {1}", header.Item1, header.Item2));
            Console.WriteLine();
        }

        private static int ReadRequestHeaders(StreamReader sr, HttpWebRequest webReq)
        {
            String httpCmd;
            int contentLen = 0;
            do
            {
                httpCmd = sr.ReadLine();
                if (String.IsNullOrEmpty(httpCmd))
                    return contentLen;
                String[] header = httpCmd.Split(colonSpaceSplit, 2, StringSplitOptions.None);
                switch (header[0].ToLower())
                {
                    case "host":
                        webReq.Host = header[1];
                        break;
                    case "user-agent":
                        webReq.UserAgent = header[1];
                        break;
                    case "accept":
                        webReq.Accept = header[1];
                        break;
                    case "referer":
                        webReq.Referer = header[1];
                        break;
                    case "cookie":
                        webReq.Headers["Cookie"] = header[1];
                        break;
                    case "proxy-connection":
                    case "connection":
                    case "keep-alive":
                        break;
                    case "content-length":
                        int.TryParse(header[1], out contentLen);
                        break;
                    case "content-type":
                        webReq.ContentType = header[1];
                        break;
                    case "if-modified-since":
                        String[] sb = header[1].Trim().Split(semiSplit);
                        DateTime d;
                        if (DateTime.TryParse(sb[0], out d))
                            webReq.IfModifiedSince = d;
                        break;
                    default:
                        try
                        {
                            webReq.Headers.Add(header[0], header[1]);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(String.Format("Could not add header {0}.  Exception message:{1}", header[0], ex.Message));
                        }
                        break;
                }
            } while (!String.IsNullOrWhiteSpace(httpCmd));
            return contentLen;
        }
    }
}