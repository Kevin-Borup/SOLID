using ConsoleApp_MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class VisaDankort : Card, ICreditNWithdrawable, IAgeRequirable, IExpirable
    {
        public DateTime ExpirationDate { get; set; }
        public DateTime ValidLength { get; set; }
        public int MonthlyCreditLimit { get; set; }
        public int MonthlyWithdrawalLimit { get; set; }
        public int MinAge { get; set; }

        public VisaDankort(string name, string accountNr) : base(name, accountNr)
        {
            MinAge = 18;
            MonthlyCreditLimit = 20000;
            MonthlyWithdrawalLimit = 25000;

            prefixes = new string[1] { "4" };
            cardNumLength = 16;
            GenerateCardNr();

            ValidLength = DateTime.ParseExact("0005", "yyyy", CultureInfo.InvariantCulture);
            GenerateExpirationDate();
        }

        public void GenerateExpirationDate()
        {
            ExpirationDate = DateTime.Now.AddYears(ValidLength.Year);
        }

        public void Purchase(double amount)
        {

        }

        public override void WithdrawAmount(double amount)
        {
            base.WithdrawAmount(amount);
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Expiration Date: {ExpirationDate.Date.ToShortDateString()}\n" +
                   $"Valid Length: {ValidLength.Year} years\n" +
                   $"Minimum Age: {MinAge}\n" +
                   $"Monthly Credit Limit: {MonthlyCreditLimit},- kr\n" +
                   $"Max Monthly Withdrawal: {MonthlyWithdrawalLimit},- kr\n";
        }

    }
}
