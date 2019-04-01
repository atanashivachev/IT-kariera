using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEncounters
{
    class OddEncountersProgram
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();

            var dict = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (dict.ContainsKey(word)) dict[word]++;
                else dict[word] = 1;
            }

            var oddEncounters = new List<string>();

            foreach (var pair in dict)
            {
                if (pair.Value % 2 != 0) oddEncounters.Add(pair.Key);
            }

            Console.WriteLine(string.Join(", ", oddEncounters));
        }
    }
}
