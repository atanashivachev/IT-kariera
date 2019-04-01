using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeSymbols
{
    class UnicodeSymbolsProgram
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var unicode = new List<string>();
            unicode.Add("");

            foreach (char letter in input)
            {
                unicode.Add(Convert.ToString(letter, 16));
            }

            Console.WriteLine(string.Join(@"u\00", unicode));
        }
    }
}
