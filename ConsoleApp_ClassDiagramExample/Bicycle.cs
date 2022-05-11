using ConsoleApp_ClassDiagramExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ClassDiagramExample
{
    class Bicycle : IBreakable
    {
        private string registrationnumber;

        public Bicycle(int numberOfWheels)
        {
            List<Wheel> wheels = new List<Wheel>(numberOfWheels);
        }

        public void Brake()
        {

        }
    }
}
