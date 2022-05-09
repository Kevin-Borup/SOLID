using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Geometry
{
    internal class Trapezoid : Square
    {
        public double B { get; private set; }
        public double C { get; private set; }
        public double D { get; private set; }
        public double Height { get; private set; }

        private double s;
        public Trapezoid(double a, double b, double c, double d) : base(a)
        {
            B = b;
            C = c;
            D = d;

            s = ((a + b - c + d) / 2);

            Height = (2 / (a - c)) * (Math.Sqrt(s * (s - a + c) * (s - b) * (s - d)));
        }

        public override double Area()
        {
            return (0.5 * (A+C) * Height);
        }

        public override double Perimeter()
        {
            return A + B + C + D;
        }
    }
}
