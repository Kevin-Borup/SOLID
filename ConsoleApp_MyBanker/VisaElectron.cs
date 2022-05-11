using ConsoleApp_MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class VisaElectron : Card, IWebNInternationable, IExpirable, IAgeRequirable
    {
        private DateTime expirationDate;
        private DateTime validLength;
        public int MaxMonthlyUsage { get; private set; }
        public int MinAge { get; set; }

        public VisaElectron(string name, string accountNr) : base(name, accountNr)
        {
            MaxMonthlyUsage = 10000;
            MinAge = 16;

            prefixes = new string[6] { "4026", "417500", "4508", "4844", "4913", "4917" };
            cardNumLength = 16;
            GenerateCardNr();

            validLength = DateTime.ParseExact("0005", "yyyy", CultureInfo.InvariantCulture);
            GenerateExpirationDate();
        }

        public void GenerateExpirationDate()
        {
            expirationDate = DateTime.Now.AddYears(validLength.Year);
        }

        public override void WithdrawAmount(double amount)
        {
            base.WithdrawAmount(amount);
        }

        public void OnlinePurchase(double amount)
        {
            throw new NotImplementedException();
        }

        public void InternationalPurchase(double amount)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Expiration Date: {expirationDate.Date.ToShortDateString()}\n" +
                   $"Valid Length: {validLength.Year} years\n" +
                   $"Minimum Age: {MinAge}\n" +
                   $"Max Monthly Usage: {MaxMonthlyUsage},- kr\n";
        }
    }
}
