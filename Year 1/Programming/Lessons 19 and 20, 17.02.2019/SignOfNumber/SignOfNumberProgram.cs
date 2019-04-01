using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfNumber
{
    class SignOfNumberProgram
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            DetermineSign(input);
        }
        static void DetermineSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number 0 is zero.");
            }
        }
    }
}
