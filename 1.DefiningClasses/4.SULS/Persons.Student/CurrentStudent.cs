using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Student
{
    class CurrentStudent : Student
    {
        public string currentCourse;

        public CurrentStudent(string firstName, string lastName, int age, string studentNum, double averageGrade, string currentCourse) : 
            base(firstName, lastName, age, studentNum, averageGrade)
        {
            CurrentCourse = currentCourse;
        }

        public string CurrentCourse 
        {
            get { return currentCourse; } 
            set
            {
                currentCourse = value;
            }
        }

        public override string ToString()
        {
            return "First Name: " + firstName + "\nLast Name: " + lastName + "\nAge: " + age + "\nStudent's Number: " + studentNum + "\nAverage Grade: " + averageGrade + "\nCurrent Course: " + currentCourse;
        }
    }
}
