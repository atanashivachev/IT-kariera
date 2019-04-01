using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetter
{
    class IndexOfLetterProgram
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++) { alphabet[i] = (char)('a' + i); }

            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (input[i] == alphabet[j]) Console.WriteLine($"{input[i]} -> {j}");
                }
            }
        }
    }
}
