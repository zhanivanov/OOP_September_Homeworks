using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal
    {
        public Cat(string name, int age, Genders gender) : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
