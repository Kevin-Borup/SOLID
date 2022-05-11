using System;
using ConsoleApp_ClassDiagramExample.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ClassDiagramExample
{
    class Car : Vehicle
    {
        private string registrationnumber;
        private string registrationYear;
        private IEngine engine;

        private Gearbox gearbox;
        private Wheel[] wheels;

        internal Car()
        {
            gearbox = new Gearbox();
            wheels = new Wheel[4] { new Wheel(), new Wheel(), new Wheel(), new Wheel() };
        }

        public Car(string color)
        {

        }

        public Car(string color, float size)
        {

        }

        public void Start()
        {

        }

        protected override void TurnLeft(float degrees)
        {

        }
    }
}
