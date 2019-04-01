using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainAir
{
    class RainAirProgram
    {
        static void Main(string[] args)
        {
            var info = new Dictionary<string, List<short>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                if (string.Join(" ", input).Equals("I believe I can fly!")) break;
                else if (input[1] != "=")
                {
                    if (info.ContainsKey(input[0])) info[input[0]].AddRange(input.Skip(1).Select(short.Parse));
                    else info.Add(input[0], input.Skip(1).Select(short.Parse).ToList());
                }
                else
                {
                    info[input[0]].Clear();
                    info[input[0]].AddRange(info[input[2]]);
                }
            }

            foreach (var pair in info.OrderByDescending(pairs => pairs.Value.Count).ThenBy(pair => pair.Key))
            {
                pair.Value.Sort();
                Console.WriteLine($"#{pair.Key} ::: {string.Join(", ", pair.Value)}");
            }
        }
    }
}
