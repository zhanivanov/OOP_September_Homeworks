using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons;
using Persons.Trainer;
using Persons.Student;

namespace SULSTest
{
    class SULSTest
    {
        static void Main()
        {
            Trainer nikbank = new JuniorTrainer("Nikolay", "Bankin", 20);
            Trainer vGeorg = new SeniorTrainer("Vlado", "Geogiev", 25);
            Trainer nakov = new SeniorTrainer("Svetlin", "Nakov", 32);
            Trainer aRus = new JuniorTrainer("Atanas", "Rusenov", 18);

            Student toi = new GraduateStudent("Zavyrshil", "Student",21, "80002341",(float)5.46);
            Student blagoi = new GraduateStudent("Blago", "Peshev",25,"80002145", (float)5.22);
            Student misho = new GraduateStudent("Misho", "Mishev", 12, "80004587", (float)5.96);

            Student pesho = new DropoutStudent("Pesho", "Peshev",23, "40001234", (float)2.33, "low result");
            Student katya = new DropoutStudent("Katya", "Ivanova", 72, "40005678", (float)4.33, "family reasons");

            CurrentStudent valyo = new OnlineStudent("Valentin", "Petrov",11, "50006541", (float)3.45,"Java Basics");
            CurrentStudent geca = new OnlineStudent("Georgi", "Petrov",34, "50002389", (float)4.45,"JavaScript Basics");
            CurrentStudent batkata = new OnsiteStudent("Botyo", "Botev",36, "50009841", (float)5.85, "C# Basics", 8);

            List<Person> persons = new List<Person>() { nikbank,vGeorg,nakov,aRus,toi, blagoi,misho,
                pesho, katya,valyo,geca,batkata};


            persons.Where(p => p is CurrentStudent).OrderBy(p => ((Student)p).AverageGrade).ToList().ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
