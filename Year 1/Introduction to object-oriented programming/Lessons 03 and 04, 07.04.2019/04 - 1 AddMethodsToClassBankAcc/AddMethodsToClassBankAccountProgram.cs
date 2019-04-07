using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___1_AddMethodsToClassBankAcc
{
    class AddMethodsToClassBankAccountProgram
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            acc.ID = 231;
            acc.Deposit(520.69);
            acc.Withdraw(120.30);

            Console.WriteLine(acc.ToString());
        }
    }
}
