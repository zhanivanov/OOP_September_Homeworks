using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    abstract class Account
    {
        private Customer customer;
        private int balance;
        private double interestRate;

        public Account(Customer customer, int balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }
        public int Balance { get; set; }
        public double InterestRate { get; set; }

        public abstract double CalculateInterest(int months);

        public void Deposit(int moneyToDeposit)
        {
            this.Balance += moneyToDeposit;
        }
    }
}
