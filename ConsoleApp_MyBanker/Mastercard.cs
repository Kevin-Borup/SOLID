using ConsoleApp_MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class Mastercard : Card, IExpirable, ICreditNWithdrawable
    {

        private DateTime expirationDate;
        private DateTime validLength;
        public int MaxDailyWithdrawal { get; private set; }
        public int MonthlyCreditLimit { get; set; }
        public int MonthlyWithdrawalLimit { get; set; }

        public Mastercard(string name, string accountNr) : base(name, accountNr)
        {
            MonthlyCreditLimit = 40000;
            MonthlyWithdrawalLimit = 30000;
            MaxDailyWithdrawal = 5000;

            prefixes = new string[5] { "51", "52", "53", "54", "55" };
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

        public void Purchase(double amount)
        {

        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Expiration Date: {expirationDate.Date.ToShortDateString()}\n" +
                   $"Valid Length: {validLength.Year} years\n" +
                   $"Monthly Credit Limit: {MonthlyCreditLimit},- kr\n" +
                   $"Max Daily Withdrawal: {MaxDailyWithdrawal},- kr\n" +
                   $"Max Monthly Withdrawal: {MonthlyWithdrawalLimit},- kr\n";
        }
    }
}
