using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CoffeeMachine
{
    /// <summary>
    /// This class represents typical home appliances
    /// </summary>
    internal abstract class Appliance
    {
        protected bool on;
        protected bool running;

        public void PowerOn()
        {
            on = true;
        }

        public void Activate()
        {
            running = true;
        }

        public void Deactivate()
        {
            running = false;
        }

        public void PowerOff()
        {
            on = false;
        }
    }
}
