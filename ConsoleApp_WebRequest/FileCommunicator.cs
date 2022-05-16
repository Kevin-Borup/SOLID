using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_WebRequest
{
    internal class FileCommunicator : IGetable
    {
        public string GetData(string file)
        {
            string fileResult = string.Empty;

            if (File.Exists(file))
            {
                fileResult = File.ReadAllText(file);
            }


            return fileResult;
        }
    }
}
