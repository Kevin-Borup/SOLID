using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_WebRequest
{
    internal class WebManager
    {
        private IGetable webGet;

        public void SetCommunicator(IGetable getter)
        {
            webGet = getter;
        }

        public string GetReply(string website)
        {
            return webGet.GetData(website);
        }
    }
}
