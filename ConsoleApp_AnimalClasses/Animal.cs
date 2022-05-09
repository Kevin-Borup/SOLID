using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_AnimalClasses
{
    internal abstract class Animal
    {
        protected string type { get { return this.GetType().Name; } } 
        protected int eyes;
        protected bool isAlive;
        protected float weight;
        protected string gender;
        protected string origin;

        public virtual void Move()
        {
            Console.WriteLine(type + " walk on land");
        }

        public void Eat()
        {
            Console.WriteLine(type + " eat");
        }
    }
}
