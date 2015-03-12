using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApplication1
{
    class Web
    {
        private void AddNewTab()
        {
            
        }

        public bool webSession()
        {

            ProcessStatus currentStatus;
            return false;
        }

        private void DisplayResults(string url, byte[] content)
        {
            var bytes = content.Length;
            var displayURL = url.Replace("http://", "");
        }


        public bool webtest()
        {
            string url = "http://www.google.com";
            webrequest(url);
            return true;

        }

        private void webrequest(string url)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            Stream stream = response.GetResponseStream();

            
            Console.WriteLine("\n----------Resquest---------");
            Console.WriteLine("Accept status: {0}",request.Accept);
            Console.WriteLine("Address: {0}", request.Address);
            Console.WriteLine("Autoredirect: {0}", request.AllowAutoRedirect);
            Console.WriteLine("Connection: {0}", request.Connection);
            Console.WriteLine("Content length: {0}", request.ContentLength);
            Console.WriteLine("Content type: {0}", request.ContentType);
            Console.WriteLine("Timeout: {0}", request.ContinueTimeout);
            Console.WriteLine("Response: {0}", request.HaveResponse);

            Console.WriteLine("\n----------Stream---------");
            Console.WriteLine("Status description: {0}", response.StatusDescription);
            
        }

        public bool webtest2()
        {
            string url = "http://www.google.com";
            simpleprocess(url);
            return true;
        }

        private void simpleprocess(string url)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}
