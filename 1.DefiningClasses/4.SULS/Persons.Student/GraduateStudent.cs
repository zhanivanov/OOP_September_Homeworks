using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons;

namespace Persons.Student
{
    class GraduateStudent : Student
    {
        public GraduateStudent(string firstName, string lastName, int age, string studentNum, double averageGrade) : 
            base(firstName, lastName, age, studentNum, averageGrade)
        {
        }
    }
}
