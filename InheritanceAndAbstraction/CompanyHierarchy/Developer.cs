using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Developer : RegularEmployee
    {
        List<Project> projects;

        public Developer(List<Project> projects, int salary, Department department, int id, string firstName, string lastName) :
            base(salary, department, id, firstName, lastName)
        {
            this.Projects = projects;
        }

        public List<Project> Projects
        {
            get { return this.projects; }
            set
            {
                this.projects = value;
            }
        }

        public override string ToString()
        {
            string projectsString = "";
            foreach (var project in projects)
            {
                projectsString += project + "\n";
            }
            return "\t-First Name: " + FirstName + "\n\t-Last Name: " + LastName + "\n\t-ID: " + ID + "\n\t-Salary: " + Salary + " leva\n\t-Department: " + Department + "\n\t-Projects: " + projectsString;
        }
    }
}
