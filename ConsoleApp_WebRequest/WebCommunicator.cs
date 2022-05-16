using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_WebRequest
{
    internal class WebCommunicator : IGetable
    {
        readonly HttpClient client = new HttpClient();

        public string GetData(string website)
        {
            string webReply = string.Empty;

            HttpResponseMessage response = client.GetAsync(website).Result;
            response.EnsureSuccessStatusCode();
            webReply = response.Content.ReadAsStringAsync().Result;

            return webReply;
        }
    }
}
