﻿using ConsoleApp_MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class Maestro : Card, IWebNInternationable, IAgeRequirable, IExpirable
    {
        public DateTime expirationDate { get; set; }
        public DateTime validLength { get; set; }
        public int MinAge { get; set; }

        public Maestro(string name, string accountNr) : base(name, accountNr)
        {
            MinAge = 18;

            prefixes = new string[9] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
            cardNumLength = 19;
            GenerateCardNr();

            validLength = DateTime.Parse("00/08/0005");
            GenerateExpirationDate();
        }

        public void GenerateExpirationDate()
        {
            DateTime currentDate = DateTime.Now;

            currentDate.AddYears(validLength.Year);
            currentDate.AddMonths(validLength.Month);

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