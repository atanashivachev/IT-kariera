using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___5_Google
{
    class GoogleProgram
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();

            while (true)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();

                if (info[0] == "End") break;

                if(!people.ContainsKey(info[0]))
                { people.Add(info[0], new Person()); }

                switch (info[1])
                {
                    case "company": people[info[0]].PCompany = new Company(info[2], info[3], float.Parse(info[4])); break;
                    case "pokemon": people[info[0]].Pokemons.Add(new Pokemon(info[2], info[3])); break;
                    case "parents": people[info[0]].Parents.Add(new FamilyMember(info[2], info[3])); break;
                    case "children": people[info[0]].Children.Add(new FamilyMember(info[2], info[3])); break;
                    case "car": people[info[0]].PCar = new Car(info[2], int.Parse(info[3])); break;
                }
            }

            Console.WriteLine(people[Console.ReadLine()].ToString());
        }
    }
}
