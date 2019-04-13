using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___4_PokeTrain
{
    class PokemonTrainerProgram
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (true)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();

                if (info[0] == "Tournament") break;

                if (!trainers.ContainsKey(info[0]))
                { trainers.Add(info[0], new Trainer(info[0], new List<Pokemon>())); }

                trainers[info[0]].Pokemons.Add(new Pokemon(info[1], info[2], int.Parse(info[3])));
            }

            while (true)
            {
                string element = Console.ReadLine();

                if (element == "End") break;

                foreach(var trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Where(p => p.Element == element).Count() > 0) trainer.Badges++;
                    else trainer.Pokemons.Select(p => p.Health -= 10).ToList();

                    trainer.Pokemons.RemoveAll(p => p.Health < 1);
                }
            }

            foreach(var trainer in trainers.Values.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine(trainer.ToString());
            }
        }
    }
}
