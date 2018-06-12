using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLVortex
{
    public class Response
    {
        String HeadLine;
        String Headers;
        String Body;
        // Function to initiate Responce header fields 
        public Response(String headLine, String headers, String body)
        {
            this.HeadLine = headLine;
            this.Headers = headers;
            this.Body = body;
        }
        // Function to initiate Responce header fields to null
        public Response()
        {
            this.HeadLine = "";
            this.Headers = "";
            this.Body = "";
        }

        public string GetHeaders()
        {
            return Headers;
        }

        public string GetHeadline()
        {
            return HeadLine;
        }

        public string GetBody()
        {
            return Body;
        }

        public override string ToString()
        {
            return HeadLine + "\r\n" + Headers + "\r\n" + Body;
        }
    }
}
