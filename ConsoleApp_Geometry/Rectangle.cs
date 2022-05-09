using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Geometry
{
    internal class Rectangle : Square
    {
        public double B { get; private set; }
        public Rectangle(double a, double b) : base (a)
        {
            B = b;
        }

        public override double Area()
        {
            return A * B;
        }

        public override double Perimeter()
        {
            return A * 2 + B * 2;
        }

    }
}
