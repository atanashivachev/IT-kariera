using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1___2_Banker
{
    class BankAccount
    {
        private int id;
        private double balance;

        public BankAccount(int id)
        {
            this.id = id;
            this.balance = 0;
        }

        public override string ToString()
        {
            return $"Bank account with id {id} has a balance of {balance:F2}";
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            { throw new ArgumentException("Withdraw value is bigger than account balance"); }

            balance -= amount;
        }

        public int Id { get => id; }
        public double Balance { get => balance; }
    }
}
