using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    class MortgageAcc : Account
    {
        public MortgageAcc(Customer customer, int balance, double interestRate) : base(customer, balance, interestRate)
        {

        }

        public override double CalculateInterest(int months)
        {
            if (base.Customer == Customer.company)
            {
                int fullInterestMonths = 0;
                double halfInterest = (base.InterestRate / 100) / 2;
                if (months > 12)
                {
                    fullInterestMonths = months - 12;

                    return base.Balance * (1 + halfInterest * 12) + base.Balance * (1 + (base.InterestRate / 100) * fullInterestMonths);
                }
                else
                {
                    return base.Balance * (1 + halfInterest * months);
                }
            }
            else
            {
                int fullInterestMonths = 0;
                double halfInterest = (base.InterestRate / 100) / 2;
                if (months > 6)
                {
                    fullInterestMonths = months - 6;

                    return base.Balance * (1 + halfInterest * 6) + base.Balance * (1 + (base.InterestRate / 100) * fullInterestMonths);
                }
                else
                {
                    return base.Balance * (1 + halfInterest * months);
                }
            }

            return -1;
        }
    }
}
