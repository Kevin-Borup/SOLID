using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class Manager
    {
        public void Starter()
        {
            Random random = new Random();
            Person person1 = new Person("Kevin Borup Hansen", DateTime.ParseExact("19/12/99", "dd/MM/yy", CultureInfo.InvariantCulture));

            string accountNr = "3520";

            for (int i = 0; i < 10; i++)
            {
                accountNr += random.Next(0, 10).ToString();
            }

            Account account1 = new Account(person1, accountNr);

            account1.AddCard("CashCard");
            account1.AddCard("Maestro");
            account1.AddCard("VisaElectron");
            account1.AddCard("VisaDankort");
            account1.AddCard("Mastercard");

            Console.WriteLine("Your cards:");
            foreach (Card card in account1.Cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
