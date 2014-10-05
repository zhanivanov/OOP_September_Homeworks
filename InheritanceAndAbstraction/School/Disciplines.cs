using System;
using System.Collections.Generic;

namespace School
{
    class Disciplines : People
    {
        private int numOfLectures;
        private List<Student> students = new List<Student>();

        public Disciplines(int numOfLectures, List<Student> students, string name, string details = null) : base(name, details)
        {
            this.NumOfLectures = numOfLectures;
            this.students = students;
        }

        public int NumOfLectures
        {
            get { return this.numOfLectures; }
            set
            {
                if (value == null || value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.numOfLectures = value;
                }
            }
        }

        public List<Student> Students
        {
            get { return this.students; } 
            set
            {
                if (value.Contains(null))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.students = value;
                }
            }
        }
    }
}
