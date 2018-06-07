using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSLVortex
{
    public static class Storage
    {        
        private static List<String> hostnames = new List<String>();
        private static List<Request> requests = new List<Request>();
        private static List<Response> responses = new List<Response>();
        private static List<ListViewItem> lstvItems = new List<ListViewItem>();

        public static int Add(string remoteHost,Request req,Response res)
        {
            
            requests.Add(req);
            responses.Add(res);
            hostnames.Add(remoteHost);
            //MessageBox.Show(hostnames[hostnames.Count - 1] + "\n" + requests[requests.Count-1].ToString() + responses[responses.Count-1].ToString());
            //MessageBox.Show(remoteHost);
            return ( requests.Count + responses.Count + hostnames.Count) / 3;
        }
        public static void Clear()
        {
            requests.Clear();
            responses.Clear();
        }

        public static Response getresponse(int i)
        {   
            return responses[i];
        }
        public static Request getrequest(int i)
        {
            return requests[i];
        }
        public static List<String> getHosts()
        {
            return hostnames;
        }
        public static int getreqlen()
        {
            return requests.Count() ;
        }
        public static int getreslen()
        {
            return responses.Count();
        }
        public static int getlen()
        {
            return (requests.Count() + responses.Count()) / 2;
        }
    }
}
