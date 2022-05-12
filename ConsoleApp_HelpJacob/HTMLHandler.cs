using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HelpJacob
{
    /// <summary>
    /// This class handles messages in regards to HTLM related issues.
    /// </summary>
    internal class HTMLHandler
    {
        public string ConvertBodyToHTML(string plainText)
        {
            return "" + plainText + "";
        }

        public Message ApplyHTMLBody(Message m, string htmlText)
        {
            m.Body = htmlText;
            return m;
        }
    }
}
