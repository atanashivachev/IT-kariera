using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseStringProgram
    {
        static void Main(string[] args)
        {
            //for the task .Reverse can't be used
            string input = Console.ReadLine();
            var reversedString = new List<char>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString.Add(input[i]);
            }

            Console.WriteLine(string.Join("", reversedString));
        }
    }
}
