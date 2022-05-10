using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyBanker
{
    internal class Person
    {
        public string Name { get; private set; }
        private DateTime dateOfBirth;
        public int Age
        {
            get {
                int tempAge = DateTime.Now.Year - dateOfBirth.Year;
                if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                {
                    tempAge--;
                }
                return tempAge; }
            private set { Age = value; }
        }

        public Person(string name, DateTime birthdate)
        {
            Name = name;
            dateOfBirth = birthdate;
        }
    }
}
