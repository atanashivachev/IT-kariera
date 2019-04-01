using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparationByRegisterOfWord
{
    class SeparationByRegisterOfWordProgram
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']').Where(x => x != " ").ToList();

            var upperCase = new List<string>();
            var lowerCase = new List<string>();
            var mixedCase = new List<string>();

            foreach (string word in input)
            {
                if (word.All(char.IsUpper)) upperCase.Add(word);
                else if (word.All(char.IsLower)) lowerCase.Add(word);
                else mixedCase.Add(word);
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}\r\nMixed-case: {string.Join(", ",mixedCase)}\r\nUpper-Case: {string.Join(", ",upperCase.Where(x => x != ""))}");
        }
    }
}
