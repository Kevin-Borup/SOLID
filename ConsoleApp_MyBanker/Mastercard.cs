using ConsoleApp_MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class Mastercard : Card, IExpirable, ICreditNWithdrawable
    {

        public DateTime expirationDate { get; set; }
        public DateTime validLength { get; set; }
        public int maxDailyWithdrawal { get; private set; }
        public int monthlyCreditLimit { get; set; }
        public int monthlyWithdrawalLimit { get; set; }

        public Mastercard(string name, string accountNr) : base(name, accountNr)
        {
            monthlyCreditLimit = 40000;
            monthlyWithdrawalLimit = 30000;
            maxDailyWithdrawal = 5000;

            prefixes = new string[5] { "51", "52", "53", "54", "55" };
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

        public override void WithdrawAmount(double amount)
        {
            base.WithdrawAmount(amount);
        }
    }
}
