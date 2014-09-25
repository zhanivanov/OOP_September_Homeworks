using System;
struct Fraction
{
    private long numerator;
    private long denominator;

    public Fraction(long numerator, long denominator) : this()
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    public long Numerator 
    {
        get { return this.numerator; } 
        set
        {
            try
            {
                this.numerator = value;
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("The value you are trying to assign to the 'numerator' is out of bounds");
            }
        }
    }

    public long Denominator 
    {
        get { return this.denominator; } 
        set
        {
            try
            {
                if (value == 0)
                {
                    throw new ArgumentException("The denominator cannot be zero!!!");
                }
                else
                {
                    this.denominator = value;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The value you are trying to assign to the 'denominator' is out of bounds");
            }
        }
    }

    public static Fraction operator -(Fraction f1, Fraction f2)
    {
        long num = f1.numerator * f2.denominator -
        f2.numerator * f1.denominator;
        long denom = f1.denominator * f2.denominator;
        return new Fraction(num, denom);
    }

    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        long num = f1.numerator * f2.denominator +
        f2.numerator * f1.denominator;
        long denom = f1.denominator * f2.denominator;
        return new Fraction(num, denom);
    }

    public override string ToString()
    {
        return ((decimal)numerator / denominator).ToString();
    }
}

class TestFractions
{
    static void Main()
    {
        Fraction fraction1 = new Fraction(23, 67);
        Fraction fraction2 = new Fraction(40, 4);
        Fraction result = fraction1 - fraction2;
        Console.WriteLine(result.Numerator);
        Console.WriteLine(result.Denominator);
        Console.WriteLine(result);
    }
}