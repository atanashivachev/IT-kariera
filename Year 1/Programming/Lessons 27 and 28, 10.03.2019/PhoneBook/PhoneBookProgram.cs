using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBookProgram
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                if (input[0] == "END") break;
                else if (input[0] == "A")
                {
                    if (!phonebook.ContainsKey(input[1])) phonebook.Add(input[1], input[2]);
                    else phonebook[input[1]] = input[2];
                }
                else
                {
                    if (!phonebook.ContainsKey(input[1])) Console.WriteLine($"Contact {input[1]} does not exist.");
                    else Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                }
            }
        }
    }
}
