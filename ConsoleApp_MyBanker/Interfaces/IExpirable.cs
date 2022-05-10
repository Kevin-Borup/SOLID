using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker.Interfaces
{
    interface IExpirable
    {
        DateTime expirationDate { get; set; }

        DateTime validLength { get; set; }

        void GenerateExpirationDate();
    }
}
