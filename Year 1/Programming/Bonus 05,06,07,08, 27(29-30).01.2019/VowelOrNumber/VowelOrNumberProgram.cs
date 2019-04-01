using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrNumber
{
    class VowelOrNumberProgram
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double i = 0;

            if (double.TryParse(input, out i))
            {
                Console.WriteLine("Digit");
            }
            else
            {
                char a = char.ToLower(input[0]);
                if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u') Console.WriteLine("Vowel");
                else Console.WriteLine("Other");
            }
        }
    }
}
