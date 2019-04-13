using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___4_PokeTrain
{
    class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(string name, List<Pokemon> pokemons)
        {
            this.name = name;
            badges = 0;
            this.pokemons = pokemons;
        }

        public override string ToString()
        {
            return $"{name} {badges} {pokemons.Count}";
        }

        public string Name { get => name; set => name = value; }
        public int Badges { get => badges; set => badges = value; }
        internal List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }
    }
}
