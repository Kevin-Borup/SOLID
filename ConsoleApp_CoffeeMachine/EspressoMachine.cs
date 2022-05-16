using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CoffeeMachine
{
    internal class EspressoMachine : Appliance
    {
        private double waterContainer = 0;

        private int cups;
        private string drink;

        private double cupMl = 200;

        public void Input(double waterMl)
        {
            waterContainer += waterMl;
        }

        public void Settings(int cups, string drink)
        {
            this.cups = cups;
            this.drink = drink;
        }

        public string[] Output()
        {
            if (on && running)
            {

                waterContainer -= cups * cupMl;

                return new string[3] { cups.ToString(), drink, "100" };
            }
            else
            {
                return new string[3] { "0", "Nothing", "0" };
            }
        }
    }
}
