using ConsoleApp_MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class Maestro : Card, IWebNInternationable, IAgeRequirable, IExpirable
    {
        private DateTime expirationDate;
        private DateTime validLength;
        public int MinAge { get; set; }

        public Maestro(string name, string accountNr) : base(name, accountNr)
        {
            MinAge = 18;

            prefixes = new string[9] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
            cardNumLength = 19;
            GenerateCardNr();

            validLength = DateTime.ParseExact("08/0005", "MM/yyyy", CultureInfo.InvariantCulture);
            GenerateExpirationDate();
        }

        public void GenerateExpirationDate()
        {
            expirationDate = DateTime.Now.AddYears(validLength.Year).AddMonths(validLength.Month);
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
                   $"Valid Length: {validLength.Year} years & {validLength.Month} months\n" +
                   $"Minimum Age: {MinAge}\n";
        }
    }
}
