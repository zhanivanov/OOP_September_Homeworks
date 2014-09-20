using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons;

namespace Persons.Student
{
    class Student : Person
    {
        public string studentNum;
        public double averageGrade;
        public Student(string firstName, string lastName, int age, string studentNum, double averageGrade) : 
            base(firstName, lastName, age)
        {
            StudentNum = studentNum;
            AverageGrade = averageGrade;
        }

        public string StudentNum 
        {
            get { return studentNum; } 
            set
            {
                studentNum = value;
            }
        }

        public double AverageGrade
        {
            get { return averageGrade; } 
            set
            {
                averageGrade = value;
            }
        }
    }
}
