using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayWithStrings
{
    class ReverseArrayWithStringsProgram
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().Split(' ').Select(Convert.ToChar).Reverse().ToArray();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
