using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(List<Sale> sales, int salary, Department department, int id, string firstName, string lastName) :
            base(salary, department, id, firstName, lastName)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales
        {
            get { return this.sales; }
            set
            {
                this.sales = value;
            }
        }

        public override string ToString()
        {
            string salesString = "";
            foreach (var sale in sales)
            {
                salesString += sale + "\n";
            }

            return "\t-First Name: " + FirstName + "\n\t-Last Name: " + LastName + "\n\t-ID: " + ID + "\n\t-Salary: " + Salary + " leva\n\t-Department: " + Department + "\n\t-Sales: " + salesString;
        }
    }
}
