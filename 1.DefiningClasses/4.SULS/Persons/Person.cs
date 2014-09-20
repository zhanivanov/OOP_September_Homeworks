using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    abstract class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public string FirstName 
        {
            get { return this.firstName; } 
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                age = value;
            }
        }
    }
}
