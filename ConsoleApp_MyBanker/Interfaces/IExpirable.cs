using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker.Interfaces
{
    interface IExpirable
    {
        //Simply too public of a solution
        //DateTime ExpirationDate { get; set; }

        //DateTime ValidLength { get; set; }

        void GenerateExpirationDate();
    }
}
