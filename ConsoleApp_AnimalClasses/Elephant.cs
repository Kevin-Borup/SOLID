using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_AnimalClasses
{
    internal class Elephant : Animal
    {
        private int legs;
        private int tusks;
        public void FillTrunk()
        {
            Console.WriteLine(type + " fills their trunk");
        }
    }
}
