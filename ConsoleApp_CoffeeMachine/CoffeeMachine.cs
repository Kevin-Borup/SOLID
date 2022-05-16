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

        private int cups;
        private string drink;
        private bool drinkChosen;

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

        public void MachineSettings(int cups, string drink)
        {
            this.cups = cups;
            this.drink = drink;
            drinkChosen = true;
        }

        public string[] Output()
        {
            if (on && running && insertedFilter)
            {
                double gramsPerCup = 16;
                if (!drinkChosen)
                {
                    cups = (int)(waterContainer / cupMl);
                    gramsPerCup = powder.Grams / cups;
                    drink = powder.Type;
                }
                

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
                drinkChosen = false;

                return new string[3] { cups.ToString(), drink, percentageStrength.ToString() };
            }
            else
            {
                return new string[3] { "0", "Nothing", "0" };
            }
        }
    }
}
