using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    class MainClass
    {
        static void Main()
        {
            DepositAcc depositAcc = new DepositAcc(Customer.company, 2341, 2.6);
            LoanAcc loanAcc = new LoanAcc(Customer.company, 10000, 6);
            loanAcc.Deposit(1000);
            depositAcc.WithdrawMoney(2300);
            Console.WriteLine(depositAcc.Balance);
            Console.WriteLine(loanAcc.Balance);
            Account mortgageAcc = new MortgageAcc(Customer.company, 6432, 3.2);

            Console.WriteLine(depositAcc.CalculateInterest(10));
            Console.WriteLine(loanAcc.CalculateInterest(5));
            Console.WriteLine(mortgageAcc.CalculateInterest(5));
        }
    }
}
