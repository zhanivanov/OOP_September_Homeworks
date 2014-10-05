using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public static class TestCompanyHierarchy
    {
        public static void Main()
        {
            List<Project> projects = new List<Project>()
            {
                new Project("project1", "23.11.2013", "project1-details", State.open),
                new Project("project2", "24.11.2014", "project2-details", State.closed),
                new Project("project3", "25.11.2015", "project3-details", State.open)
            };

            List<Sale> sales = new List<Sale>()
            {
                new Sale("Water", "11.11.2011", 24),
                new Sale("Sugar", "22.22.2012", 21),
            };

            List<Employee> employees = new List<Employee>()
            {
               new Developer(projects, 782, Department.Production, 23, "Georgi", "Ivanov"),
               new SalesEmployee(sales, 872, Department.Sales, 1, "Yordan", "Ivanov"),
               new Developer(projects, 976, Department.Marketing, 23, "Petur", "Georgiev")
            };
            Employee manager = new Manger(employees, 2321, Department.Marketing, 23, "Svetlin", "Nakov");
            projects[0].CloseProjcet();
        }
    }
}
