using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___5_Google
{
    class Person
    {
        private string name;
        private Company pCompany;
        private List<Pokemon> pokemons;
        private List<FamilyMember> parents;
        private List<FamilyMember> children;
        private Car pCar;

        public Person()
        {
            pCompany = new Company();
            pokemons = new List<Pokemon>();
            parents = new List<FamilyMember>();
            children = new List<FamilyMember>();
            pCar = new Car();
        }

        public Person(string name, Company pCompany, List<Pokemon> pokemons, 
                        List<FamilyMember> parents, List<FamilyMember> children)
        {
            this.name = name;
            this.pCompany = pCompany;
            this.pokemons = pokemons;
            this.parents = parents;
            this.children = children;
        }

        public override string ToString()
        {
            StringBuilder toReturn = new StringBuilder();
            toReturn.Append($"Company:\r\n");

            if (pCompany.Name != null) toReturn.Append($"{pCompany.ToString()}\r\n");

            toReturn.Append($"Car:\r\n");

            if (pCar.Model != null) toReturn.Append($"{pCar.ToString()}\r\n");

            toReturn.Append($"Pokemon:\r\n");

            foreach (var pokemon in pokemons)
            { toReturn.Append($"{pokemon.ToString()}\r\n"); }

            toReturn.Append($"Parents:\r\n");

            foreach(var parent in parents)
            { toReturn.Append($"{parent.ToString()}\r\n"); }

            toReturn.Append($"Children:\r\n");

            foreach(var child in children)
            { toReturn.Append($"{child.ToString()}\r\n"); }

            return toReturn.ToString();
        }

        public string Name { get => name; set => name = value; }
        public Company PCompany { get => pCompany; set => pCompany = value; }
        public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }
        public List<FamilyMember> Parents { get => parents; set => parents = value; }
        public List<FamilyMember> Children { get => children; set => children = value; }
        public Car PCar { get => pCar; set => pCar = value; }
    }
}
