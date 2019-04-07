using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___1_AddMethodsToClassBankAcc
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance;}
            private set { balance = value;}
        }

        public void Deposit (Double amount)
        {
            Balance += amount;
        }

        public void Withdraw (Double amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {id}, balance {balance}";
        }
    }
}
