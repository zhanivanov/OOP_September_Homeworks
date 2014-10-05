using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumenStudentWorker
{
    class Student : Human
    {
        private string facultyNum;

        public Student(string facultyNum, string firstName, string lastName) : base(firstName, lastName)
        {
            this.FacultyNum = facultyNum;
        }

        public string FacultyNum 
        {
            get { return this.facultyNum; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("facultyNum", "Cannot be null or empty");
                }
                else
                {
                    this.facultyNum = value;
                }
            }
        }

        public override string ToString()
        {
            return "First name: " + this.FirstName + "\nLast name: " + this.LastName + "\nFaculty number: " + this.FacultyNum + "\n";
        }
    }
}
