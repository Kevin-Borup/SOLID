using ConsoleApp_MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class VisaDankort : Card, ICreditNWithdrawable, IAgeRequirable, IExpirable
    {
        public DateTime expirationDate { get; set; }
        public DateTime validLength { get; set; }
        public int monthlyCreditLimit { get; set; }
        public int monthlyWithdrawalLimit { get; set; }
        public int MinAge { get; set; }

        public VisaDankort(string name, string accountNr) : base(name, accountNr)
        {
            MinAge = 18;
            monthlyCreditLimit = 20000;
            monthlyWithdrawalLimit = 25000;

            prefixes = new string[1] { "4" };
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
