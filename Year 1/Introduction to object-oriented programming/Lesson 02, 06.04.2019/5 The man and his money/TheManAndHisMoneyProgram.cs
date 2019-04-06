using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_The_man_and_his_money
{
    class TheManAndHisMoneyProgram
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person{ Age = 29, Name = "Jorj"};

            firstPerson.AddBankAccount(new BankAccount{ ID = 1, Balance = 384.91});
            firstPerson.AddBankAccount(new BankAccount{ ID = 2, Balance = 1927.34});

            Console.WriteLine(firstPerson.GetBalance());
        }
    }
}
