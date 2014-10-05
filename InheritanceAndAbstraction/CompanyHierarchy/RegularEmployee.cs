using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    abstract public class RegularEmployee : Employee
    {
        public RegularEmployee(int salary, Department department, int id, string firstName, string lastName) :
            base(salary, department, id, firstName, lastName)
        {

        }
    }
}
