using System;
using ConsoleApp_ClassDiagramExample.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ClassDiagramExample
{
    class Toyota : IGasolineEngine, IBreakable
    {
        private float capacity;

        public Toyota(float c)
        {
            capacity = c;
        }

        public void Brake()
        {

        }

        public void Inject()
        {

        }

        public void Start()
        {

        }

        public void TurnOff()
        {

        }
    }
}
