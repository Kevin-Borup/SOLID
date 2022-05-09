using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Geometry
{
    internal class Parallelogram : Square
    {
        public double B { get; set; }
        public double Angle { get; set; }
        public Parallelogram(double a, double b, double angle) : base(a)
        {
            B = b;
            Angle = angle;
        }

        public override double Area()
        {
            return Math.Abs(A * B * Math.Sin(Angle));
        }

        public override double Perimeter()
        {
            return A * 2 + B * 2;
        }
    }
}
