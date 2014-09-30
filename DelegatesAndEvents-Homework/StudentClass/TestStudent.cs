namespace StudentClass
{
    using System;

    public class TestStudentClass
    {
        public static void Main()
        {
            Student student = new Student("Gosho", 22);
            student.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine(
                    "Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName,
                    eventArgs.OldValue,
                    eventArgs.NewValue);
            };

            student.Name = "Zhoro";
            student.Age = 25;
        }
    }
}