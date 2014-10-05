using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Customer : Person
    {
        private int net;

        public Customer(int net, int id, string firstName, string lastName) : base(id, firstName, lastName)
        {
            this.NET = net;
        }

        public int NET { get; set; }
    }
}
