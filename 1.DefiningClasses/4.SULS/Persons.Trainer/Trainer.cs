using System;
using Persons;
using System.Collections.Generic;

namespace Persons.Trainer
{
    class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
        }
        public List<string> courses = new List<string>();
        public void CreateCourse(string courseName)
        {
            courses.Add(courseName);
            Console.WriteLine(courseName);
        }
    }
}
