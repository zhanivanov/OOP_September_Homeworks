using System;
using System.Collections.Generic;

namespace School
{
    class Class
    {
        private List<Teacher> teachers = new List<Teacher>();
        private string uti;

        public Class(List<Teacher> teachers, string uti)
        {
            this.teachers = teachers;
            this.UTI = uti;
        }

        public string UTI 
        {
            get { return this.uti; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.uti = value;
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            string classUTI = "UTI: " + uti + "\n";
            foreach (Teacher teacher in teachers)
            {
                result += "Teacher - " + teacher.Name + "\n";
                foreach(var discipline in teacher.Disciplines)
                {
                    result += "Discipline: \n\t" + discipline.Name + " - " + discipline.NumOfLectures + " lectures.\nStudents: \n";
                    foreach (var students in discipline.Students)
                    {
                        result += "\t" + students.Name + " - UCN: " + students.UCN + "\n";
                    }
                }
            }
            result = classUTI + result;

            return result;
        }
    }
}
