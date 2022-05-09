using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_AnimalClasses
{
    internal class Crab : Animal
    {
        private int legs;
        private int pincers;
        public void Swim()
        {
            Console.WriteLine(type + " swims in the water");
        }

        public void Pinch()
        {
            Console.WriteLine(type + " uses their pinchers");
        }
    }
}
