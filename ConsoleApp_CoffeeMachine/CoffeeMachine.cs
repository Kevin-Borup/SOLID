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
        private bool insertedFilter = false;
        private double coffeeGrams = 0;

        private double cupMl = 200;
        private int optimalCoffeeGrams = 16;

        public void Input(double waterMl, double coffeeGrams)
        {
            waterContainer += waterMl;
            this.coffeeGrams = coffeeGrams;
        }

        public void InsertFilter()
        {
            insertedFilter = true;
        }

        public int[] Output()
        {
            if (on && running && insertedFilter)
            {
                int cups = (int)(waterContainer / cupMl);

                int gramsPerCup = (int)coffeeGrams / cups;
                int percentageStrength = (optimalCoffeeGrams / gramsPerCup) * 100;

                return new int[2] { cups, percentageStrength };
            }
            else
            {
                return new int[2] { 0, 0 };
            }
        }
    }
}
