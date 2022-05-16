using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_WebRequest
{
    internal class WebManager
    {
        private IWebGet webGet;

        public WebManager(IWebGet getter)
        {
            webGet = getter;
        }

        public string GetWebReply(string website)
        {
            return webGet.GetWebReply(website);
        }
    }
}
