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
            Starter();
        }

        private void Starter()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Chose Get Type:");
                Console.WriteLine(" Website");
                Console.WriteLine(" File\n");
                Console.Write("Write the type: ");
                switch (Console.ReadLine().ToLower())
                {
                    case "website":
                        WebSite();
                        break;
                    case "file":
                        File();
                        break;
                }
                Console.Read();

            }
        }

        private void WebSite()
        {
            webManager.SetCommunicator(new WebCommunicator());
            Console.Write("URL of the website: ");
            string website = GetUserInput();
            string webReply = GetReply(website);
            Console.WriteLine(webReply);
        }


        private void File()
        {
            webManager.SetCommunicator(new FileCommunicator());
            Console.Write("Location of the file: ");
            string file = GetUserInput();
            string fileReply = GetReply(file);
            Console.WriteLine(fileReply);
        }
        private string GetReply(string website)
        {
            return webManager.GetReply(website);
        }

        private string GetUserInput()
        {
             return Console.ReadLine();
        }
    }
}
