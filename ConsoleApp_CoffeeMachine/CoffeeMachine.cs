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

        private Powder powder;

        private double cupMl = 200;
        private double optimalCoffeeGrams = 16;
        private double optimalTeaGrams = 12;


        public void Input(double waterMl, Powder powder)
        {
            waterContainer += waterMl;
            this.powder = powder;
        }

        public void InsertFilter()
        {
            insertedFilter = true;
        }

        public void RemoveFilter()
        {
            insertedFilter = false;
        }

        public int[] Output()
        {
            if (on && running && insertedFilter)
            {
                int cups = (int)(waterContainer / cupMl);
                double gramsPerCup = powder.Grams / cups;

                int percentageStrength = 0;

                if (powder.Type.Equals("Coffee"))
                {
                    percentageStrength = Convert.ToInt32((optimalCoffeeGrams / gramsPerCup) * 100);
                }
                else if (powder.Type.Equals("Tea"))
                {
                    percentageStrength = Convert.ToInt32((optimalTeaGrams / gramsPerCup) * 100);
                }

                waterContainer -= cups * cupMl;
                

                return new int[2] { cups, percentageStrength };
            }
            else
            {
                return new int[2] { 0, 0 };
            }
        }
    }
}
