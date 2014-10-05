using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten : Animal
    {
        public Kitten(string name, int age) : base(name, age, Genders.female)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("female meow");
        }
    }
}
