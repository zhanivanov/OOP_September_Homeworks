using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PlayWithStudents
{
    static void Main()
    {
        IList<Student> students = new List<Student>();
        students.Add(new Student("Gosho", "Aoshev", 23, "235124", "+359 28465654", "gosho@email.com", new List<int>() { 3, 5, 6 }, 2));
        students.Add(new Student("Peter", "Aetrov", 21, "4325324", "088243242", "pesho@email.com", new List<int>() { 4, 2, 5 }, 6));
        students.Add(new Student("Ivan", "Ivanov", 20, "213124", "+3592421545", "ivan@email.com", new List<int>() { 1, 5, 6 }, 3));
        students.Add(new Student("Zhan", "Ivanov", 32, "464353", "42342342342", "zhan@abv.bg", new List<int>() { 6, 5, 3 }, 2));
        students.Add(new Student("Pavel", "Pavlov", 53, "85645", "54364356", "pavel@email.com", new List<int>() { 4, 5, 4 }, 2));
        students.Add(new Student("Yordan", "Yordanov", 13, "43657", "025482182", "yordan@email.com", new List<int>() { 3, 2, 6 }, 8));

        IEnumerable<Student> orderedbygroup = students.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);
        foreach (var item in orderedbygroup)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        IEnumerable<Student> orderedByFirstAndLastName = students.Where(x => x.FirstName.CompareTo(x.Lastname) < 0);
        foreach (var item in orderedByFirstAndLastName)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        IEnumerable<Student> orderByAge = students.Where(x => x.Age > 18 && x.Age < 24);
        foreach (var item in orderByAge)
        {
            Console.WriteLine(item.FirstName + " " + item.Lastname + " - " + item.Age);
        }

        Console.WriteLine();

        IEnumerable<Student> sortedStudents = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.Lastname);
        foreach (var item in sortedStudents)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        IEnumerable<Student> sortedByEmailDomain = students.Where(x => x.Email.EndsWith("@abv.bg"));
        foreach (var item in sortedByEmailDomain)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        IEnumerable<Student> sortedPhoneNums = students.Where(x => x.Phone.StartsWith("02") || x.Phone.StartsWith("+3592") || x.Phone.StartsWith("+359 2"));
        foreach (var item in sortedPhoneNums)
        {
            Console.WriteLine(item);
        }

        IEnumerable<Student> excellentStudents = students.Where(x => x.Marks >= 1);
        foreach (var item in excellentStudents)
        {
            Console.WriteLine(item);
        }

        var weakStudents = students.Where(s => Utilities.CountElementsInList(s.Marks, 2) == 2);
        foreach (var item in weakStudents)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Marks of students enrolled in 2014:\n");
        students.Where(s => s.FacultyNumber[5] == '1' && s.FacultyNumber[6] == '4').ToList().ForEach(x => x.Marks.ToList().ForEach(mark => Console.WriteLine(mark)));

    }
}
