using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker.Interfaces
{
    internal interface ICreditNWithdrawable
    {
        int monthlyCreditLimit { get; set; }
        int monthlyWithdrawalLimit { get; set; }
    }
}
