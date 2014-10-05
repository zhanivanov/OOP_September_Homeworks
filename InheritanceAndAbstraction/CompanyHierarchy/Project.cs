using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Project
    {
        private string projectName;
        private string projectStartDate;
        private string details;
        private State state;

        public Project(string projectName, string projectStartDate, string details, State state)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.StateProp = state;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                this.projectName = value;
            }
        }

        public string ProjectStartDate
        {
            get { return this.projectStartDate; }
            set
            {
                this.projectStartDate = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                this.details = value;
            }
        }

        public State StateProp
        {
            get { return this.state; }
            set
            {
                this.state = value;
            }
        }

        public void CloseProjcet()
        {
            this.StateProp = State.closed;
        }

        public override string ToString()
        {
            return "\n\t\tProject name: " + ProjectName + "\n\t\tProject start date: " + ProjectStartDate + "\n\t\tDetails: " + Details + "\n\t\tState: " + StateProp;
        }
    }
}
