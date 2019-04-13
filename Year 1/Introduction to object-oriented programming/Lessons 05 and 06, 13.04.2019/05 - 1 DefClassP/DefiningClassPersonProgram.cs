using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___1_DefClassP
{
    class DefiningClassPersonProgram
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Gosho", 9);

            List<BankAccount> bAcc = new List<BankAccount>();
            bAcc.Add(new BankAccount { Id = 1, Money = 238.94});
            bAcc.Add(new BankAccount { Id = 2, Money = 32.40});

            Person p2 = new Person("Alex", 45, bAcc);

            Console.WriteLine(p1.GetBalance());
            Console.WriteLine(p2.GetBalance());
        }
    }
}
