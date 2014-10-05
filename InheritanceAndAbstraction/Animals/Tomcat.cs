using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat : Animal
    {
        public Tomcat(string name, int age) : base(name, age, Genders.male)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("male meow");
        }
    }
}
