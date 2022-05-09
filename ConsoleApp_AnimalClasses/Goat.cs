using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_AnimalClasses
{
    internal class Goat : Animal
    {
        private int legs;
        private int horns;

        public void Ram()
        {
            Console.WriteLine(type + "rams forward");
        }
    }
}
