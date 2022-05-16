using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CoffeeMachine
{
    internal class TeaMachine : Appliance
    {
        private double waterContainer = 0;
        private double grams;

        private int cups;

        private double cupMl = 200;
        private double optimalTeaGrams = 12;

        public void Input(double waterMl, double grams)
        {
            waterContainer += waterMl;
            this.grams = grams;
        }

        public string[] Output()
        {
            if (on && running)
            {
                cups = (int)(waterContainer / cupMl);
                double gramsPerCup = grams / cups;

                int percentageStrength = Convert.ToInt32((optimalTeaGrams / gramsPerCup) * 100);

                waterContainer -= cups * cupMl;

                return new string[3] { cups.ToString(), "Tea", percentageStrength.ToString() };
            }
            else
            {
                return new string[3] { "0", "Nothing", "0" };
            }
        }
    }
}
