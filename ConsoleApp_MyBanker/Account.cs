using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class Account
    {
        private Person owner;
        private string accountNr;
        private List<Card> accounts = new List<Card>();
        public Account(Person owner, string accountNr)
        {
            this.owner = owner;
            this.accountNr = accountNr;
        }

        public void AddCard(Card newCard)
        {
            if (newCard is CashCard)
            {
                accounts.Add((CashCard)newCard);
            }
            else if (newCard is Maestro)
            {
                accounts.Add((Maestro)newCard);
            }
            else if (newCard is VisaElectron)
            {
                accounts.Add((VisaElectron)newCard);
            }
            else if (newCard is VisaDankort)
            {
                accounts.Add((VisaDankort)newCard);
            }
            else if (newCard is Mastercard)
            {
                accounts.Add((Mastercard)newCard);
            }
        }
    }
}
