using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNumber
{
    class CheckNumberProgram
    {
        static void Main(string[] args)
        {
            long number;
            bool type = long.TryParse(Console.ReadLine(), out number);

            if (type)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
