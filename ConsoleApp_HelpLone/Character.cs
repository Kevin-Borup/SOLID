using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HelpLone
{
    abstract class Character
    {
        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }
        public void Fight()
        {
            Console.WriteLine("I'm fighting");

        }
    }
}
