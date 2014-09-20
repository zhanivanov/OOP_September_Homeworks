using System;
using System.Collections.Generic;

class Computer
{
    private string name;
    private List<Component> components = new List<Component>();
    private long price;

    public Computer(string name, List<Component> components)
    {
        this.Name = name;
        this.Components = components;
        foreach (Component component in Components)
        {
            price += component.Price;
        }
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
    public List<Component> Components 
    {
        get { return this.components; } 
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value cannot be null", "Components");
            }
            else
            {
                this.components = value;
            }
        }
    }

    public void PrintInfo()
    {
        string info = "PC Info:\nName: " + Name + "\nPrice: " + String.Format("{0:C}",price);
        info += "\n----------\nComponents Details:\n";
        foreach (Component component in Components)
        {
            info += "\n" + component.Name + " -> " + String.Format("{0:C}", component.Price);
        }
        Console.WriteLine(info);
    }
}