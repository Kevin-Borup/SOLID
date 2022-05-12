using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HelpJacob
{
    /// <summary>
    /// This Class takes care of sending messages.
    /// </summary>
    internal class MessageSender
    {
        public void SendMessage(MessageMethod.MessageCarrier type, Message m)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageMethod.MessageCarrier.Smtp))
            {
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageMethod.MessageCarrier.VMessage))
            {
                //her implementeres alt koden til at sende via VMessage
            }
        }
        
        public void SendMessageToAll(MessageMethod.MessageCarrier type, string[] to, Message m)
        {
            if (type.Equals(MessageMethod.MessageCarrier.Smtp))
            {
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageMethod.MessageCarrier.VMessage))
            {
                //her implementeres alt koden til at sende via VMessage
            }
        }

        
    }
}
