using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Student
{
    class DropoutStudent : Student
    {
        public string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, string studentNum, double averageGrade, string dropoutReason) : 
            base(firstName, lastName, age, studentNum, averageGrade)
        {
            DropoutReason = dropoutReason;
        }

        public string DropoutReason 
        {
            get { return dropoutReason; } 
            set
            {
                dropoutReason = value;
            }
        }
        public void Reapply()
        {
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Student Number: " + studentNum);
            Console.WriteLine("Average grade: " + averageGrade);
            Console.WriteLine("Dropout reason: " + dropoutReason);
        }
    }
}
