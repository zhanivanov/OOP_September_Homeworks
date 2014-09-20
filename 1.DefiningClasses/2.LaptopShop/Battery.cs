using System;

class Battery
{
    private string type;
    private string batteryLife;


    public string Type
    {
        get { return this.type; }
        set
        {
            if(value != null && value.Length < 1)
            {
                throw new ArgumentException("Invalid value");
            }
            else
            {
                this.type = value;
            }
        }
    }
    public string batteryLIFE 
    {
        get { return this.batteryLife; }
        set 
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentException("Invalid value");
            }
            else
            {
                this.batteryLife = value;
            }
        } 
    }
}