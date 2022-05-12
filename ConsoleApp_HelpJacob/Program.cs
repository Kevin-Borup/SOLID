// See https://aka.ms/new-console-template for more information
using ConsoleApp_HelpJacob;

Console.WriteLine("Hello, World!");


namespace thisNamespace
{
    public class Program
    {

        public static void Main(string[] args)
        {
            MessageSender sender = new MessageSender();
            HTMLHandler handler = new HTMLHandler();

            string to = "";
            string[] toAll = new string[2] { "", "" };
            string from = "";
            string body = "";
            string subject = "";
            string cc = "";

            Message message = new Message(to, from , body, subject, cc);

            sender.SendMessage(MessageMethod.MessageCarrier.VMessage, message);
            sender.SendMessageToAll(MessageMethod.MessageCarrier.Smtp, toAll, message);

            message = handler.ApplyHTMLBody(message, handler.ConvertBodyToHTML(message.Body));

            sender.SendMessage(MessageMethod.MessageCarrier.VMessage, message);
            sender.SendMessageToAll(MessageMethod.MessageCarrier.Smtp, toAll, message);
        }
    }

}