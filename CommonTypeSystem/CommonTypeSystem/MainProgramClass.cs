using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystem
{
    class MainProgramClass
    {
        static void Main()
        {
            //List<Payment> payments = new List<Payment>();
            //payments.Add(new Payment("Vafli", 23));
            //payments.Add(new Payment("Shokolad", 123));
            //payments.Add(new Payment("Banica", 11));
            //Customer customer1 = new Customer("Ivan", "Angelov", "Ivanov", "1", "Ulica Sezam 32", "088835596268", "ivan@abv.bg", payments, CustomerType.Golden);
            //Customer customer2 = new Customer("Ivan", "Angelov", "Ivanov", "2", "Ulica Sezam 23", "088875564262", "gosho@abv.bg", payments, CustomerType.Regular);
            //Customer customer3 = customer1;

            //Console.WriteLine(customer1.Equals(customer2));
            //Console.WriteLine(customer1.Equals(customer3));

            //Console.WriteLine(customer2);

            //Console.WriteLine(customer1.CompareTo(customer2));
            //Console.WriteLine(customer1.CompareTo(customer3));

            //Customer deepCopy = (Customer)customer2.Clone();
            //customer2.FirstName = "Zhan";
            //Console.WriteLine(deepCopy);
            //Console.WriteLine(customer2);
            List<Payment> payments = new List<Payment>()
            {
                new Payment("book", 24),
                new Payment("phone", 243),
                new Payment("tablet", 500),
                new Payment("phone", 234),
                new Payment("tablet", 500)
            };

            var pesho = new Customer("Petar", "Ivanov", "Mitrev", "12312412", "Ulica Sezam", "241134134", "pesho@email.com", payments, CustomerType.Diamond);



            Console.WriteLine("Pesho before cloning:\n{0}", pesho);
            Console.WriteLine();
            Customer cloning = (Customer)pesho.Clone();

            cloning.Payments[1].Price = 2001;

            Console.WriteLine("Pesho after cloninig:\n{0}", cloning);
        }
    }
}
