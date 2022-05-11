using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ClassDiagramExample
{
    class Gearbox
    {
        class GearType
        {
            private string name;

            public static new void GetType()
            {

            }
        }

        private int currentGear;

        public void ShiftUp(int steps)
        {
            this.GetType();
            GearType.GetType();
        }

        public void ShiftDown(int steps)
        {

        }
    }
}
