using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    class DepositAcc : Account
    {
        public DepositAcc(Customer customer, int balance, double interestRate) : base(customer, balance, interestRate)
        {

        }

        public override double CalculateInterest(int months)
        {
            if(this.Balance > 0 && this.Balance > 1000)
            {
                return this.Balance * (1 + (this.InterestRate / 100) * months); 
            }

            return -1;
        }

        public void WithdrawMoney(int moneyToWithdraw)
        {
            if (moneyToWithdraw > this.Balance)
            {
                Console.WriteLine("You do not have enough money!");
            }
            else
            {
                this.Balance -= moneyToWithdraw;
            }
        }
    }
}
