using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Manger : Employee, IManager
    {
        private List<Employee> employees;

        public Manger(List<Employee> employees, int salary, Department department, int id, string firstName, string lastName) :
            base(salary, department, id, firstName, lastName)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees
        {
            get { return this.employees; }
            set
            {
                this.employees = value;
            }
        }

        public override string ToString()
        {
            string employeesString = "";
            foreach (var employee in employees)
            {
                employeesString += employee + "\n";
            }
            return "First Name: " + FirstName + "\nLast Name: " + LastName + "\nID: " + ID + "\nSalary: " + Salary + " leva\nDepartment: " + Department + "\nEmployees:\n" + employeesString;
        }
    }
}
