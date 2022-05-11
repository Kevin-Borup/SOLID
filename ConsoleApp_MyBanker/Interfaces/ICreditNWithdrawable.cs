using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker.Interfaces
{
    internal interface ICreditNWithdrawable
    {
        int MonthlyCreditLimit { get; set; }
        int MonthlyWithdrawalLimit { get; set; }
    }
}
