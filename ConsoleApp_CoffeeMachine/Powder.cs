using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CoffeeMachine
{
    internal class Powder
    {
        public double Grams { get; private set; }
        public string Type { get; private set; }

        public Powder(double grams, string type)
        {
            Grams = grams;
            Type = type;
        }
    }
}
