using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Methods
{
    class MethodsProgram
    {
        static void Main(string[] args)
        {
            BankAccount bAcc = new BankAccount();

            bAcc.ID = 153;
            bAcc.Deposit(15);
            bAcc.Withdraw(5);

            Console.WriteLine($"Account {bAcc.ID}, balance {bAcc.Balance}");
        }
    }
}
