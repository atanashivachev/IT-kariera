using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1___2_Banker
{
    static class Bank
    {
        //added/changed the code functinality because the task was too unprecise
        private static int IDS = 1;
        private static Dictionary<int, BankAccount> bAccounts = new Dictionary<int, BankAccount>();

        public static void AddAcc()
        {
            bAccounts.Add(IDS, new BankAccount(IDS));
            Console.WriteLine($"Added a bank account with id {IDS}");

            IDS++;
        }

        public static void Withdraw(int id, double amount)
        {
            CheckExist(id);

            bAccounts[id].Withdraw(amount);
        }

        public static void Deposit(int id, double amount)
        {
            CheckExist(id);

            bAccounts[id].Deposit(amount);
        }

        public static void Info(int id)
        {
            CheckExist(id);

            Console.WriteLine(bAccounts[id]);
        }

        private static void CheckExist(int id)
        {
            if (!bAccounts.ContainsKey(id))
            { throw new ArgumentException("Bank account doesn't exist!"); }
        }
    }
}
