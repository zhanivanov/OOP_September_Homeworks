using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestProgram
{
    static void Main()
    {
        InterestCalculator simpleInterest = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
        Console.WriteLine("{0:0.0000}", simpleInterest.CalculatedInterest);
        InterestCalculator CompoundInterest = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
        Console.WriteLine("{0:0.0000}", CompoundInterest.CalculatedInterest);
    }

    public static double GetSimpleInterest(double money, double interest, int years)
    {
        return money * (1 + ((interest / 100) * years));
    }

    public static double GetCompoundInterest(double money, double interest, int years)
    {
        return money * Math.Pow((1 + ((interest / 100) / 12)), years * 12);
    }
}