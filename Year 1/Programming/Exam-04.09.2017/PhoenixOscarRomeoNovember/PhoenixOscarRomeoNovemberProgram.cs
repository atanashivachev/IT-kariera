using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixOscarRomeoNovember
{
    class PhoenixOscarRomeoNovemberProgram
    {
        static void Main(string[] args)
        {
            var squadMates = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', '-', '>').Where(x => x != "").ToArray();
                if (input[0] == "Blaze" && input[1] == "it!") break;

                if (input[0].CompareTo(input[1]) != 0)
                {
                    if (squadMates.ContainsKey(input[0]))
                    {
                        if (!squadMates[input[0]].Contains(input[1])) squadMates[input[0]].Add(input[1]);
                    }
                    else
                    {
                        List<string> temp = new List<string> {input[1]};
                        squadMates.Add(input[0], temp);
                    }
                }
            }

            var squadMatesCount = new Dictionary<string, int>();

            foreach (var pair in squadMates)
            {
                int mates = pair.Value.Count();

                foreach (var mate in pair.Value)
                {
                    if (squadMates.ContainsKey(mate) && squadMates[mate].Contains(pair.Key))
                    {
                        mates--;
                    }
                }
                squadMatesCount.Add(pair.Key, mates);
            }

            foreach (var pair in squadMatesCount.OrderByDescending(pairs => pairs.Value))
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }
    }
}
