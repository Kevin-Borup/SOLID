using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ClassDiagramExample
{
    class Factory
    {
        public static void Instance()
        {

        }

        private Factory()
        {

        }

        public Vehicle Create(int type)
        {
            Vehicle newVehicle = new Car();
            return newVehicle;
        }
    }
}
