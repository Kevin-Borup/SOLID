using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Geometry
{
    internal class Square
    {
        public double A { get; private set; }

        public Square(double a)
        {
            A = a;
        }

        public virtual double Perimeter()
        {
            return A*4;
        }

        public virtual double Area()
        {
            return A * A;
        }

        public override string ToString()
        {
            return base.GetType().Name;
        }
    }
}
