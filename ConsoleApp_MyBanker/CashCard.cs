using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class CashCard : Card
    {
        public CashCard(string name, string accountNr) : base(name, accountNr)
        {
            prefixes = new string[1] { "2400" };
            cardNumLength = 16;
            GenerateCardNr();
        }
    }
}
