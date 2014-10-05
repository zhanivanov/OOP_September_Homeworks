using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class TestAnimals
    {
        static void Main()
        {
            Cat[] cats = 
            { 
                new Cat("cat1", 12, Genders.male),
                new Cat("cat2", 22, Genders.female),
                new Cat("cat3", 32, Genders.female),
                new Cat("cat4", 11, Genders.male)
            };

            Dog[] dogs = 
            { 
                new Dog("dog1", 64, Genders.male),
                new Dog("dog2", 3, Genders.female),
                new Dog("dog3", 32, Genders.female),
                new Dog("dog4", 43, Genders.male)
            };

            Frog[] frogs = 
            { 
                new Frog("frog1", 11, Genders.male),
                new Frog("frog2", 43, Genders.female),
                new Frog("frog3", 8, Genders.female),
                new Frog("frog4", 1, Genders.male)
            };

            Kitten[] kittens = 
            { 
                new Kitten("kitten1", 9),
                new Kitten("kitten2", 5),
                new Kitten("kitten3", 4),
                new Kitten("kitten4", 1)
            };

            Tomcat[] tomcats = 
            { 
                new Tomcat("tomcat1", 43),
                new Tomcat("tomcat2", 32),
                new Tomcat("tomcat3", 25),
                new Tomcat("tomcat4", 17)
            };

            cats[0].ProduceSound();
            dogs[0].ProduceSound();
            frogs[0].ProduceSound();
            kittens[0].ProduceSound();
            tomcats[0].ProduceSound();

            Console.WriteLine(cats.Average(x => x.Age));
            Console.WriteLine(dogs.Average(x => x.Age));
            Console.WriteLine(frogs.Average(x => x.Age));
            Console.WriteLine(kittens.Average(x => x.Age));
            Console.WriteLine(tomcats.Average(x => x.Age));
        }
    }
}
