using ConsoleApp_MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class VisaElectron : Card, IWebNInternationable, IExpirable, IAgeRequirable
    {
        public DateTime expirationDate { get; set; }
        public DateTime validLength { get; set; }
        public int maxMonthlyUsage { get; private set; }
        public int MinAge { get; set; }

        public VisaElectron(string name, string accountNr) : base(name, accountNr)
        {
            maxMonthlyUsage = 10000;
            MinAge = 16;

            prefixes = new string[6] { "4026", "417500", "4508", "4844", "4913", "4917" };
            cardNumLength = 16;
            GenerateCardNr();

            validLength = DateTime.Parse("00/00/0005");
            GenerateExpirationDate();
        }

        public void GenerateExpirationDate()
        {
            DateTime currentDate = DateTime.Now;

            currentDate.AddYears(validLength.Year);

            expirationDate = currentDate;
        }

        public void OnlinePurchase(double amount)
        {
            throw new NotImplementedException();
        }

        public void InternationalPurchase(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
