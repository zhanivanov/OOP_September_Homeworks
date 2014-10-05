using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public Student(string firstName, string lastName, int age, string facultyNum, string phone, string email, IList<int> marks, int groupNum)
    {
        this.FirstName = firstName;
        this.Lastname = lastName;
        this.Age = age;
        this.FacultyNumber = facultyNum;
        this.Phone = phone;
        this.Email = email;
        this.Marks = marks;
        this.GroupNumber = groupNum;
    }

    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }
    public string FacultyNumber { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public IList<int> Marks { get; set; }
    public int GroupNumber { get; set; }

    public override string ToString()
    {
        return "First Name: " + FirstName + "\nLast Name: " + Lastname + "\nAge: " + Age + "\nFaculty Number: " + FacultyNumber + "\nPhone: " + Phone + "\nEmail: " + Email + "\nMarks: " + printMarks(Marks) + "\nGroup Number: " + GroupNumber;
    }

    private string printMarks(IList<int> marks)
    {
        string marksString = "";
        foreach (var item in marks)
        {
            marksString += item + ", ";
        }

        return marksString.TrimEnd(',', ' ');
    }
}