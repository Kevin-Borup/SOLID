using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_WebRequest
{
    internal class GUI
    {
        WebManager webManager;

        public GUI()
        {
            webManager = new WebManager(new Communicator());
            Starter();
        }

        private void Starter()
        {
            Console.Write("Write the website: ");
            string website = GetUserInput();
            string webReply = GetWebReply(website);
            Console.WriteLine(webReply);
        }

        private string GetWebReply(string website)
        {
            return webManager.GetWebReply(website);
        }

        private string GetUserInput()
        {
             return Console.ReadLine();
        }
    }
}
