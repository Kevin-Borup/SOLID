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
        private string cardNr;
        private string accountNr;

        public Card(string name, string card, string account)
        {
            this.name = name;
            cardNr = card;
            accountNr = account;
        }

        public virtual void WithdrawAmount(double amount)
        {

        }

        protected void GenerateCardNr()
        {

        }
    }
}
