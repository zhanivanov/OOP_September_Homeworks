using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private string ram;
    private string hdd;
    private string graphicsCard;
    private string screen;
    private double price;
    private Battery battery = new Battery();


    public Laptop(string model, double price)
    {
        this.Model = model;
        this.Price = price;
    }

    public Laptop(string model, double price, string manufacturer = null, string processor = null, string ram = null, string hdd = null, string graphicsCard = null, string screen = null, string type = null, string batteryLife = null) : this(model,price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.Price = price;
        this.Battery.Type = type;
        this.Battery.batteryLIFE = batteryLife;
    }


    public string Model 
    {
        get { return this.model; } 
        set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Model cannot be empty value");
            }
            else
            {
                this.model = value;
            }
        }
    }

    public double Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be negative value");
            }
            else
            {
                this.price = value;
            }
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; } 
        set
        {
            if(value != null && value.Length < 1)
            {
                throw new ArgumentException("Invalid value for manufacturer");
            }
            else
            {
                this.manufacturer = value;
            }
        }
    }

    public string Processor
    {
        get { return this.processor; }
        set
        {
            if(value != null && value.Length < 1)
            {
                throw new ArgumentException("Invalid value for processor!");
            }
            else
            {
                this.processor = value;
            }
        }
    }

    public string Ram
    {
        get { return this.ram; }
        set
        {
            if(value != null && value.Length < 1)
            {
                throw new ArgumentException("Invalid value for RAM!!!");
            }
            else
            {
                this.ram = value;
            }
        }
    }

    public string Hdd
    {
        get { return this.hdd; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentException("Invalid value for hdd!");
            }
            else
            {
                this.hdd = value;
            }
        }
    }

    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentException("Invalid value for graphics card!");
            }
            else
            {
                this.graphicsCard = value;
            }
        }
    }

    public Battery Battery
    {
        get { return this.battery; }
        set { this.battery = value; }
    }

    public string Screen
    {
        get { return this.screen; }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentException("Invalid value for screen!");
            }
            else
            {
                this.screen = value;
            }
        }
    }

    public override string ToString()
    {
        string info = "Laptop info:\n";
        if (Model != null) { info += "Model: " + Model; }
        if (Manufacturer != null) { info += "\nManufacturer: " + Manufacturer; }
        if (Processor != null) { info += "\nProcessor: " + Processor; }
        if (Ram != null) { info += "\nRAM: " + Ram; }
        if (GraphicsCard != null) { info += "\nGraphicsCard: " + GraphicsCard; }
        if (Hdd != null) { info += "\nHDD: " + Hdd; }
        if (Screen != null) { info += "\nScreen: " + Screen; }
        if (Battery.Type != null) { info += "\nBattery GeneralInfo: " + Battery.Type; }
        if (Battery.batteryLIFE != null) { info += "\nBattery Life: " + Battery.batteryLIFE; }
        if (Price != 0) { info += "\nPrice: " + Price + " lv."; }
        return info;
    }
}