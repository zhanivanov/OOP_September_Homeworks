using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Persons
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                    new Person("Gosho", 54),
                    new Person("Pesho", 26, "alabala@dir.bg"),
                    new Person("Angel", 14, "alabala@.dir.bg"),
            };
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
        }
    }
}