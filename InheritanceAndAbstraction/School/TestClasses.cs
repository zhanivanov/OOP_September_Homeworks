using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class TestClasses
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("542", "Georgi Georgiev"));
            students.Add(new Student("111", "Georgi Kadiev"));
            students.Add(new Student("432", "Ivan Georgiev"));
            students.Add(new Student("974", "Petar Petrov"));
            students.Add(new Student("214", "Atanas Iliev"));

            List<Disciplines> disciplines = new List<Disciplines>();
            disciplines.Add(new Disciplines(11, students, "Physics"));
            disciplines.Add(new Disciplines(15, students, "Math"));
            disciplines.Add(new Disciplines(20, students, "Programming"));

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher(disciplines, "Svetlin Nakov", "The Software Guru"));
            teachers.Add(new Teacher(disciplines, "Petur Hubchev"));

            Class classA = new Class(teachers, "A");
            Class classV = new Class(teachers, "V");

            Console.WriteLine(classA);
            Console.WriteLine(classV);
        }
    }
}
