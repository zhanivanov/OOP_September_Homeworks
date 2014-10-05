using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    abstract public class Employee : Person, IEmployee
    {
        private int salary;
        private Department department;

        public Employee(int salary, Department department, int id, string firstName, string lastName) : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public int Salary 
        {
            get { return this.salary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.salary = value;
                }
            }
        }

        public Department Department 
        {
            get { return this.department; }
            set
            {
                this.department = value;
            }
        }
    }
}
