using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Defining_of_class_BankAccount
{
    class DefiningOfClassBankAccountProgram
    {
        static void Main(string[] args)
        {
            BankAccount bAcc = new BankAccount();

            bAcc.ID = 18234;
            bAcc.Balance = 104.75;

            Console.WriteLine($"Account {bAcc.ID}, balance {bAcc.Balance}");
        }
    }
}
