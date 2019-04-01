using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPopulation
{
    class CountPopulationProgram
    {
        static void Main(string[] args)
        {
            var countries = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] info = Console.ReadLine().Split('|').ToArray();
                if (info[0].Equals("report")) break;

                int people = int.Parse(info[2]);
                if (countries.ContainsKey(info[1]))
                {
                    if (countries[info[1]].ContainsKey(info[0])) countries[info[1]][info[0]] += people;
                    else countries[info[1]].Add(info[0], people);
                }
                else
                {
                    countries.Add(info[1], new Dictionary<string, int>());
                    countries[info[1]].Add(info[0], people);
                }
            }

            foreach (var pair in countries.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");
                foreach (var city in pair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
