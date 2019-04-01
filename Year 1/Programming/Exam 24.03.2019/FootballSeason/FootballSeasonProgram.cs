using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSeason
{
    class FootballSeasonProgram
    {
        static void Main(string[] args)
        {
            //solved in 9 min, 100/100 points

            var players = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', '-').Where(x => x != "").ToArray();

                if (string.Join(" ", input).Equals("End of season")) break;
                else
                {
                    if (players.ContainsKey(input[0])) players[input[0]] += int.Parse(input[1]);
                    else players.Add(input[0], int.Parse(input[1]));
                }
            }

            foreach (var pair in players.OrderBy(pair => pair.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
