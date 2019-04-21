using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1___1_Teams
{
    class TeamsProgram
    {
        static void Main(string[] args)
        {
            Team gnTeam = new Team("Gorno Nanadolnishte");

            for(int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();

                try
                {
                    Person toAdd = new Person(info[0], info[1], short.Parse(info[2]), double.Parse(info[3]));

                    gnTeam.AddPlayer(toAdd);
                }
                catch (ArgumentException ex)
                { Console.WriteLine(ex.Message); }
            }

            Console.WriteLine($"First team have {gnTeam.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team have {gnTeam.ReserveTeam.Count} players");
        }
    }
}
