using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class PalindromeProgram
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] reversed = input.Reverse().ToArray();
            string reversedInput = string.Join("", reversed);

            bool palindrome = false;
            if (input.CompareTo(reversedInput) == 0) palindrome = true;

            Console.WriteLine(palindrome);
        }
    }
}
