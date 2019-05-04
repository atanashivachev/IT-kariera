using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_15._07._2017
{
    static class DraftManager
    {
        public static string mode;

        public static double totalStoredEnergy;
        public static double totalMinedOre;

        private static Dictionary<string, Harvester> harvesterDict = new Dictionary<string, Harvester>();
        private static Dictionary<string, Provider> providerDict = new Dictionary<string, Provider>();

        public static void RegisterHarvester(List<string> arguments)
        {
            try
            {
                switch (arguments.Count())
                {
                    case 6: harvesterDict.Add(arguments[2], new Harvester("Sonic", arguments[2], int.Parse(arguments[3]), double.Parse(arguments[4]), sbyte.Parse(arguments[5]))); break;
                    case 5: harvesterDict.Add(arguments[2], new Harvester(arguments[1], arguments[2], int.Parse(arguments[3]), double.Parse(arguments[4]))); break;
                }
                Console.WriteLine($"Successfully registered {arguments[1]} Harvester – {arguments[2]}");
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
        }

        public static void RegisterProvider(List<string> arguments)
        {
            try
            {
                providerDict.Add(arguments[2], new Provider(arguments[1], arguments[2], double.Parse(arguments[3])));
                Console.WriteLine($"Successfully registered {arguments[1]} Provider – {arguments[2]}");
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
        }

        public static void Day()
        {
            Console.WriteLine("A day has passed.");

            totalStoredEnergy += providerDict.Values.Sum(p => p.EnergyOutput);
            Console.WriteLine($"Energy Provided: {providerDict.Values.Sum(p => p.EnergyOutput)}");

            if (totalStoredEnergy >= TotalEnergyRequiered() && mode != "Energy")
            {
                totalStoredEnergy -= TotalEnergyRequiered();
                MineOre();
            }
            else Console.WriteLine("Plumbus Ore Mined: 0");
        }

        private static void MineOre()
        {
            switch (mode)
            {
                case "Half":
                    totalMinedOre += harvesterDict.Values.Sum(h => h.OreOutput) * 0.5;
                    Console.WriteLine($"Plumbus Ore Mined: {harvesterDict.Values.Sum(h => h.OreOutput) * 0.5}");
                    break;
                default:
                    totalMinedOre += harvesterDict.Values.Sum(h => h.OreOutput);
                    Console.WriteLine($"Plumbus Ore Mined: {harvesterDict.Values.Sum(h => h.OreOutput)}");
                    break;
            }
        }

        private static double TotalEnergyRequiered()
        {
            switch (mode)
            {
                case "Half": return harvesterDict.Values.Sum(h => h.EnergyRequirement) * 0.6;
                default: return harvesterDict.Values.Sum(h => h.EnergyRequirement);
            }
        }

        public static void Mode(List<string> arguments)
        {
            mode = arguments[1];
            Console.WriteLine($"Successfully changed working mode to {arguments[1]} Mode");
        }

        public static void Check(List<string> arguments)
        {
            string id = arguments[1];

            if (!harvesterDict.ContainsKey(id) && !providerDict.ContainsKey(id))
            { throw new ArgumentException($"No element found with id – {id}"); }

            if (harvesterDict.ContainsKey(id))
            {
                Console.WriteLine($"{harvesterDict[id].Type} Harvester - {id}");
                Console.WriteLine($"Ore Output: {harvesterDict[id].OreOutput}");
                Console.WriteLine($"Energy Requirement: {harvesterDict[id].EnergyRequirement}");
            }
            else
            {
                Console.WriteLine($"{providerDict[id].Type} Provider - {id}");
                Console.WriteLine($"Energy Output: {providerDict[id].EnergyOutput}");
            }
        }

        public static void Shutdown()
        {
            Console.WriteLine("System Shutdown");
            Console.WriteLine($"Total Energy Stored: {totalStoredEnergy}");
            Console.WriteLine($"Total Mined Plumbus Ore: {totalMinedOre}");
        }
    }
}
