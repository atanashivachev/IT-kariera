using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairEmail
{
    class RepairEmailProgram
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string name = Console.ReadLine();
                if (name.Equals("stop")) break;

                string email = Console.ReadLine();

                if(!email.ToLower().EndsWith("us") && !email.ToLower().EndsWith("uk")) Console.WriteLine($"{name} -> {email}");
            }
        }
    }
}
