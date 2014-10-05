using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumenStudentWorker
{
    class TestHumanStudetWorker
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("00011", "Georgi", "Georgiev"));
            students.Add(new Student("00002", "Ivan", "Ivanov"));
            students.Add(new Student("00003", "Petar", "Goranov"));
            students.Add(new Student("00024", "Luben", "Dilov"));
            students.Add(new Student("03505", "Boiko", "Borisov"));
            students.Add(new Student("00006", "Yordan", "Ganev"));
            students.Add(new Student("20007", "Ivailo", "Ivailov"));
            students.Add(new Student("00008", "Pavlin", "Rahnev"));
            students.Add(new Student("06009", "Daniel", "Ivanov"));
            students.Add(new Student("70010", "Georgi", "Petrov"));

            //IEnumerable<Student> orderedStudents = students.OrderBy(x => x.FacultyNum);
            //foreach (Student student in orderedStudents)
            //{
            //    Console.WriteLine(student);
            //}

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker(120, 48, "Ivan", "Petrov"));
            workers.Add(new Worker(321, 25, "Petar", "Ivanov"));
            workers.Add(new Worker(342, 54, "Gosho", "Goshev"));
            workers.Add(new Worker(125, 64, "Pesho", "Georgiev"));
            workers.Add(new Worker(453, 31, "Angel", "Angelov"));
            workers.Add(new Worker(542, 75, "Maxim", "Vanchev"));
            workers.Add(new Worker(332, 48, "Chris", "Krastev"));
            workers.Add(new Worker(753, 86, "Hristo", "Gochev"));
            workers.Add(new Worker(12, 4, "Jivko", "Ganev"));
            workers.Add(new Worker(123, 12, "Ivailo", "Petrov"));

            //IEnumerable<Worker> orderedWorkers = workers.OrderBy(x => x.MoneyPerHour());
            //foreach (Worker worker in orderedWorkers)
            //{
            //    Console.WriteLine(worker);
            //}

            var mergedLists = new List<Human>(students.Count + workers.Count);
            mergedLists.AddRange(students);
            mergedLists.AddRange(workers);

            IEnumerable<Human> orderedHumans = mergedLists.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            foreach (var item in orderedHumans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
;