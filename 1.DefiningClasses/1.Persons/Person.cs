using System;

class Person
{
    private string name;
    private int age;
    private string email;
    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }
    public Person(string name, int age) : this(name, age, null) { }
    public string Name 
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be empty!!!");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public int Age 
    {
        get { return this.age; }
        set 
        {
            if(value >= 1 && value <= 100){
                this.age = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Age must be in the range [1...100]");
            }
        }
    }
    public string Email
    {
        get { return this.email; }
        set
        {
            if (value == null || value.Contains("@"))
            {
                this.email = value;
            }
            else
            {
                throw new ArgumentException("Invalid email!");
            }
        }
    }
    public override string ToString()
    {
        return string.Format("name: {0}, age: {1}", this.name, this.age) + (this.email == null ? "" : ", email: " + this.Email);
        
    }
}