using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_AnimalClasses
{
    internal class Spider : Animal
    {
        private int legs;
        private bool venomous;

        public void Climb()
        {
            Console.WriteLine(type + " climbs up");
        }

        public void Bite()
        {
            Console.WriteLine(type + " bites");
        }
    }
}
