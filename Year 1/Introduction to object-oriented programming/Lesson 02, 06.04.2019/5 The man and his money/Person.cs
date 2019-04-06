using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_The_man_and_his_money
{
    class Person
    {
        private string name;
        private byte age;

        //if you write just private List<BankAccount> accounts; it will create a null list, null lists are bad, but like this you create an empty list, with which you can do your normal stuff
        private List<BankAccount> accounts = new List<BankAccount>();

        public string Name
        {
            get {return name;}
            set {name = value;}
        }
        
        public byte Age
        {
            get { return age; }
            set { age = value;}
        }

        public void AddBankAccount(BankAccount bAcc)
        {
            accounts.Add(bAcc);
        }

        public double GetBalance()
        {
            double sum = 0;

            foreach (var acc in accounts)
            {
                sum += acc.Balance;
            }

            return sum;
        }
    }
}
