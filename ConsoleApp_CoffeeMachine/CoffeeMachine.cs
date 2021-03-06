using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CoffeeMachine
{
    /// <summary>
    /// This class represents a coffeemachine
    /// </summary>
    internal class CoffeeMachine : Appliance
    {
        private double waterContainer = 0;
        private double grams;
        private bool insertedFilter = false;

        private int cups;

        private double cupMl = 200;
        private double optimalCoffeeGrams = 16;


        public void Input(double waterMl, double grams)
        {
            waterContainer += waterMl;
            this.grams = grams;
        }

        public void InsertFilter()
        {
            insertedFilter = true;
        }

        public void RemoveFilter()
        {
            insertedFilter = false;
        }

        public string[] Output()
        {
            if (on && running && insertedFilter)
            {
                cups = (int)(waterContainer / cupMl);
                double gramsPerCup = grams / cups;


                int percentageStrength = Convert.ToInt32((optimalCoffeeGrams / gramsPerCup) * 100);


                waterContainer -= cups * cupMl;

                return new string[3] { cups.ToString(), "Coffee", percentageStrength.ToString() };
            }
            else
            {
                return new string[3] { "0", "Nothing", "0" };
            }
        }
    }
}
