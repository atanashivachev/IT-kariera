using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Test_client
{
    class TestClientProgram
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, BankAccount>();

            while(true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command[0].Equals("End")) break;

                switch (command[0])
                {
                    case "Create": Create(command[1], accounts); break;
                    case "Deposit": Deposit(int.Parse(command[1]), int.Parse(command[2]), accounts); break;
                    case "Withdraw": Withdraw(int.Parse(command[1]), int.Parse(command[2]), accounts); break;
                    case "Print": Print(int.Parse(command[1]), accounts); break;
                }
            }
        }

        public static void Create (string stringProposedId, Dictionary<int, BankAccount> accounts)
        {
            int proposedId = int.Parse(stringProposedId);

            if (accounts.ContainsKey(proposedId)) Console.WriteLine("Account already exists");
            else
            {
                var tempBA = new BankAccount();
                tempBA.ID = proposedId;

                accounts.Add(proposedId, tempBA);
            }
        }

        public static void Deposit (int accountId, int amount, Dictionary<int, BankAccount> accounts)
        {
            if(accounts.ContainsKey(accountId)) accounts[accountId].Deposit(amount);
            else Console.WriteLine("Account does not exist");
        }

        public static void Withdraw (int accountId, int amount, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(accountId))
            {
                if (amount > accounts[accountId].Balance) Console.WriteLine("Insufficient balance"); 
                else accounts[accountId].Withdraw(amount);
            }
            else Console.WriteLine("Account does not exist");
        }

        public static void Print (int accountId, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(accountId)) Console.WriteLine($"Account ID{accountId}, balance {accounts[accountId].Balance:F2}");
            else Console.WriteLine("Account does not exist");
        }
    }
}
