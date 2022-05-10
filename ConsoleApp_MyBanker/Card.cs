using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal abstract class Card
    {
        private string name;
        private string number;
        private string accountNr;
        protected string[] prefixes;
        protected int cardNumLength;

        public Card(string name, string accountNr)
        {
            this.name = name;
            this.accountNr = accountNr;
        }

        public virtual void WithdrawAmount(double amount)
        {

        }

        protected void GenerateCardNr()
        {
            Random random = new Random();

            string selectedPrefix = prefixes[random.Next(prefixes.Length)];

            number = selectedPrefix;

            for (int i = 0; i < cardNumLength - number.Length; i++)
            {
                number += random.Next(0, 10).ToString();
            }
        }
    }
}
