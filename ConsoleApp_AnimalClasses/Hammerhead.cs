using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_AnimalClasses
{
    internal class Hammerhead : Animal
    {
        private int fins;
        private int gills;
        public override void Move()
        {
            Console.WriteLine(type + " swims in the water");
        }

        public void Pound()
        {
            Console.WriteLine(type + " pounds with their head");
        }
    }
}
