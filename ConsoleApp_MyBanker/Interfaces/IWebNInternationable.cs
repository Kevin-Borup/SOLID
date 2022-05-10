using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker.Interfaces
{
    internal interface IWebNInternationable
    {
        public void OnlinePurchase(double amount);
        public void InternationalPurchase(double amount);
    }
}
