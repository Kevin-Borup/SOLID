using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class Account
    {
        public Person Owner { get; private set; }
        public string Number { get; private set; }
        public double Balance { get; private set; }
        public List<Card> Cards { get; private set; }
        public Account(Person owner, string accountNr)
        {
            Owner = owner;
            Number = accountNr;

            Cards = new List<Card>();
        }

        public void AddCard(string cardType)
        {
            switch (cardType)
            {
                case "CashCard":
                    Cards.Add(new CashCard(Owner.Name, Number));
                    break;
                case "Maestro":
                    Maestro newMaestro = new Maestro(Owner.Name, Number);
                    if (newMaestro.MinAge <= Owner.Age)
                    {
                        Cards.Add(newMaestro);
                    }
                    break;
                case "VisaElectron":
                    VisaElectron newElectron = new VisaElectron(Owner.Name, Number);
                    if (newElectron.MinAge <= Owner.Age)
                    {
                        Cards.Add(newElectron);
                    }
                    break;
                case "VisaDankort":
                    VisaDankort newDankort = new VisaDankort(Owner.Name, Number);
                    if (newDankort.MinAge <= Owner.Age)
                    {
                        Cards.Add(newDankort);
                    }
                    break;
                case "Mastercard":
                    Cards.Add(new Mastercard(Owner.Name, Number));
                    break;
            }
        }
    }
}
