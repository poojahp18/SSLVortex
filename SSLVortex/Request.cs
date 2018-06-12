using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SSLVortex
{
    public class Request
    {
        String HeadLine;
        String Headers;
        String Body;
        Dictionary<String, String> HeaderDictionary = new Dictionary<string, string>();
        public Request(String headLine,String headers,String body)
        {
            this.HeadLine = headLine;
            this.Headers = headers;
            this.Body = body;
           
            this.ParseHeaders();
        }
        public Request ()
        {
            this.HeadLine = "";
            this.Headers = "";
            this.Body = "";
        }
        public void ParseHeaders()
        {
            HeaderDictionary.Clear();
            foreach (string st in Headers.Split(new[] { "\r\n" }, StringSplitOptions.None))
            {
                if(st.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries).Length > 1)
                {
                    HeaderDictionary.Add(st.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries)[0], st.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries)[1]);
                }                    
            }            
        }
        public KeyValuePair<string, string> getHeader(string key)
        {
            return new KeyValuePair<string, string> (key, HeaderDictionary[key]);
        }
        public string GetHeadline()
        {
            return HeadLine;
        }
        public string GetHeaders()
        {
            return Headers;
        }
        public string GetBody()
        {
            return Body;
        }

        public override string ToString()
        {
            return HeadLine  + "\r\n" + Headers + "\r\n" + Body;
        }
        public string[] parseHost()
        {            
            string[] s = HeadLine.Split(' ').ToArray();
            return s;
        }

    }
}
