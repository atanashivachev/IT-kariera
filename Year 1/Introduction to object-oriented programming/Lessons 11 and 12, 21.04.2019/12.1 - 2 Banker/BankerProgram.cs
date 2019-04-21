using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1___2_Banker
{
    class BankerProgram
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();
                if (info[0] == "END") break;

                try
                {
                    switch (info[0])
                    {
                        case "Add": Bank.AddAcc(); break;
                        case "Withdraw": Bank.Withdraw(int.Parse(info[1]), double.Parse(info[2])); break;
                        case "Deposit": Bank.Deposit(int.Parse(info[1]), double.Parse(info[2])); break;
                        case "Info": Bank.Info(int.Parse(info[1])); break;
                        default: Console.WriteLine("Please enter a valid command."); break;
                    }
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            }
        }
    }
}
