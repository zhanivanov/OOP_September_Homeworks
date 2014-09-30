using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate double CalculateInterest(double money, double interest, int years);

class InterestCalculator
{
    private double money;
    private double interest;
    private int years;
    private double calculatedInterest;

    public InterestCalculator(double money, double interest, int years, CalculateInterest del)
    {
        this.Money = money;
        this.Interest = interest;
        this.Years = years;
        this.CalculatedInterest = del(money, interest, years);

    }

    public double Money { get; set; }
    public double Interest { get; set; }
    public int Years { get; set; }
    public double CalculatedInterest { get; set; }
}