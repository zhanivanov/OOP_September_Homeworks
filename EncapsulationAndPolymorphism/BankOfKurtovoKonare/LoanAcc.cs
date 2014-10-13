using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    class LoanAcc : Account
    {
        public LoanAcc(Customer customer, int balance, double interestRate) : base(customer, balance, interestRate)
        {

        }

        public override double CalculateInterest(int months)
        {
            if(base.Customer == Customer.individual)
            {
                return base.Balance * (1 + (base.InterestRate / 100) * (months - 3));
            }

            return base.Balance * (1 + (base.InterestRate / 100) * (months - 2));
        }
    }
}
