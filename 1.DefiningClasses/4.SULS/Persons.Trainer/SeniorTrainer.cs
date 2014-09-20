﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Trainer
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age) :
            base(firstName, lastName, age)
        {

        }
        public void DeleteCourse(string courseName)
        {
            Console.WriteLine(courseName);
            courses.Remove(courseName);
        }
    }
}
