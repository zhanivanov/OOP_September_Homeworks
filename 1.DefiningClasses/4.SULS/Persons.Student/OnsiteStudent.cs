using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Student
{
    class OnsiteStudent : CurrentStudent
    {
        public int numberOfVisits;

        public OnsiteStudent(string firstName, string lastName, int age, string studentNum, double averageGrade, string currentCourse, int numberOfVisits) : 
            base(firstName, lastName, age, studentNum, averageGrade, currentCourse)
        {
            NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits 
        {
            get { return numberOfVisits; } 
            set
            {
                numberOfVisits = value;
            }
        }

        public override string ToString()
        {
            return "First Name: " + firstName + "\nLast Name: " + lastName + "\nAge: " + age + "\nStudent's Number: " + studentNum + "\nAverage Grade: " + averageGrade + "\nCurrent Course: " + currentCourse + "\nNumber of visits: " + numberOfVisits;
        }
    }
}
