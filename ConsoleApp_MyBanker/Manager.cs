using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class Manager
    {
        public void Starter()
        {
            Random random = new Random();
            Person person1 = new Person("Kevin Borup Hansen", DateTime.Parse("19/12/99"));

            string accountNr = "3520";

            for (int i = 0; i < 10; i++)
            {
                accountNr += random.Next(0, 10).ToString();
            }

            Account account1 = new Account(person1, accountNr);


        }
    }
}
