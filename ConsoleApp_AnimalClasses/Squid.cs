using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_AnimalClasses
{
    internal class Squid : Animal
    {
        private int amountOfInk;
        private int tentacles;
        public override void Move()
        {
            Console.WriteLine(type + " swims in water");
        }
        public void Ink()
        {
            Console.WriteLine(type + " sprays their ink");
        }
    }
}
