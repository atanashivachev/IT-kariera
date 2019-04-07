using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___1_DefiningClassBankAccount
{
    class DefiningClassBankAccountProgram
    {
        static void Main(string[] args)
        {
            //writing the same thing for the 3rd time, bad exercises so far
            BankAccount acc = new BankAccount();

            acc.ID = 21;
            acc.Balance = 234.93;

            Console.WriteLine($"Account {acc.ID}, balance {acc.Balance}");
        }
    }
}
