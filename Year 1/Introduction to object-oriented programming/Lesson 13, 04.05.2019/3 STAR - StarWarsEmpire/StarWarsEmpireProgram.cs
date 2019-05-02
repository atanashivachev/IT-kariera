using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_STAR___StarWarsEmpire
{
    class StarWarsEmpireProgram
    {
        static void Main(string[] args)
        {
            string[] planetsInfo = Console.ReadLine().Split(' ').ToArray();
            string[] buildingsInfo = Console.ReadLine().Split(' ').ToArray();
            string[] shipsInfo = Console.ReadLine().Split(' ').ToArray();

            Dictionary<string, Planet> planetsDict = new Dictionary<string, Planet>();
            for (int i = 0; i < planetsInfo.Length; i += 3)
            {
                try
                {
                    planetsDict.Add(planetsInfo[i], new Planet(planetsInfo[i], int.Parse(planetsInfo[i + 1]), int.Parse(planetsInfo[i + 2])));
                }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            }

            Dictionary<string, Building> buildingsDict = new Dictionary<string, Building>()
            {
                { "MetalMine", new Building("MetalMine") },
                { "MineralMine", new Building("MineralMine") },
                { "YardShip", new Building("YardShip") }
            };
            for (int i = 0; i < buildingsInfo.Length; i += 3)
            {
                try
                {
                    buildingsDict[buildingsInfo[i]].Metal = int.Parse(buildingsInfo[i + 1]);
                    buildingsDict[buildingsInfo[i]].Mineral = int.Parse(buildingsInfo[i + 2]);
                }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            }

            Dictionary<string, Ship> shipsDict = new Dictionary<string, Ship>()
            {
                { "Transporter", new Ship("Transporter") },
                { "BattleShip", new Ship("BattleShip") },
                { "Fighter", new Ship("Fighter") }
            };
            for (int i = 0; i < shipsInfo.Length; i += 3)
            {
                try
                {
                    shipsDict[shipsInfo[i]].Metal = int.Parse(shipsInfo[i + 1]);
                    shipsDict[shipsInfo[i]].Mineral = int.Parse(shipsInfo[i + 2]);
                }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            }

            string lastPlanet = "";
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
                if (command[0] == "END") break;

                if (command[0] == "TIME")
                { planetsDict[lastPlanet].Time(int.Parse(command[1])); }
                else if (command.Length == 2)
                { planetsDict[command[0]].BuildBuilding(buildingsDict[command[1]]); lastPlanet = command[0]; }
                else
                { planetsDict[command[0]].BuildShips(shipsDict[command[1]], int.Parse(command[2])); lastPlanet = command[0]; }
            }

            Console.WriteLine("Resources:");
            foreach (var knownPlanet in planetsDict.Values)
            {
                Console.WriteLine($"{knownPlanet.Name} Metal {knownPlanet.Metal} Mineral {knownPlanet.Mineral}");
            }

            Console.WriteLine("Buildings:");
            foreach (var knownPlanet in planetsDict.Values)
            {
                if (knownPlanet.BuildingsList.Count() == 0) Console.WriteLine($"On {knownPlanet.Name} there are no buildings.");
                else
                {
                    Console.Write($"{knownPlanet.Name}");

                    foreach (var knownBuilding in buildingsDict.Values)
                    { Console.Write($" {knownBuilding.Name} {knownPlanet.BuildingsList.Count(b => b.Name == knownBuilding.Name)}"); }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ships:");
            foreach (var knownPlanet in planetsDict.Values)
            {
                if (knownPlanet.ShipsList.Count() == 0) Console.WriteLine($"On {knownPlanet.Name} there are not ships.");
                else
                {
                    Console.Write($"{knownPlanet.Name}");

                    foreach (var knownShip in shipsDict.Values)
                    { Console.Write($" {knownShip.Name} {knownPlanet.ShipsList.Count(b => b.Name == knownShip.Name)}"); }
                }
                Console.WriteLine();
            }
        }
    }
}
