using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Geometry
{
    internal class Triangle : Square
    {
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c) : base(a)
        {
            B = b;
            C = c;
        }
        
        public override double Area()
        {
            return (0.5) * A * B;
        }

        public override double Perimeter()
        {
            return A + B + C;
        }
    }
}