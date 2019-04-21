using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1___2_Footbal
{
    class FootballTeamProgram
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teamsDict = new Dictionary<string, Team>();

            while (true)
            {
                string[] info = Console.ReadLine().Split(';').ToArray();
                if (info[0] == "END") break;

                try
                {
                    switch (info[0])
                    {
                        case "Team": teamsDict.Add(info[1], new Team(info[1])); break;
                        case "Add":
                            if (!teamsDict.ContainsKey(info[1]))
                            { throw new ArgumentException($"Team {info[1]} does not exists."); }

                            teamsDict[info[1]].AddPlayer(new Player(info[2], info.Skip(3).Select(int.Parse).ToArray()));
                            break;
                        case "Remove": teamsDict[info[1]].RemovePlayer(info[2]); break;
                        case "Rating":
                            if (!teamsDict.ContainsKey(info[1]))
                            { throw new ArgumentException($"Team {info[1]} does not exists."); }

                            Console.WriteLine(teamsDict[info[1]]);
                            break;
                    }
                }
                catch (ArgumentException ex)
                { Console.WriteLine(ex.Message); }
            }
        }
    }
}
