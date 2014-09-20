using System;

class Component
{
    private string name;
    private long price;
    private string details;

    public Component(string name, long price, string details = null)
    {
        this.Name = name;
        this.Price = price;
        this.Details = details;
    }

    public string Name
    {
        get { return this.name; } 
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid value for name!");
            }
            else
            {
                this.name = value;
            }
        }
    }

    public string Details 
    {
        get { return this.details; } 
        set
        {
            if (string.IsNullOrEmpty(value) && value !=null)
            {
                throw new ArgumentException("Invalid value for details!");
            }
            else
            {
                this.details = value;
            }
        }
    }

    public long Price
    {
        get { return this.price; } 
        set
        {
            if (value<0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be negative!");
            }
            else
            {
                this.price = value;
            }
        }
    }

}