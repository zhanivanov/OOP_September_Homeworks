using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Genders gender;

        public Animal(string name, int age, Genders gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "Cannot be empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age 
        {
            get { return this.age; } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative number!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public Genders Gender 
        {
            get
            { 
                return this.gender; 
            } 
            set
            {
                this.gender = value;
            }
        }

        public abstract void ProduceSound();
    }
}
