using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___1_DefClassP
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> bankAccounts;


        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.bankAccounts = new List<BankAccount>();
        }

        public Person(string name, int age, List<BankAccount> bankAccounts)
        {
            this.name = name;
            this.age = age;
            this.bankAccounts = bankAccounts;
        }

        public double GetBalance()
        {
            return bankAccounts.Select(b => b.Money).Sum();
        }
    }
}
