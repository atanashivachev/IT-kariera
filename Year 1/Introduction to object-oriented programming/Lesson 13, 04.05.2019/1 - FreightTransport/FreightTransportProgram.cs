using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___FreightTransport
{
    class FreightTransportProgram
    {
        static void Main(string[] args)
        {
            string[] trucksInfo = Console.ReadLine().Split(';').Where(s => s != "").ToArray();
            string[] freightsInfo = Console.ReadLine().Split(';').Where(s => s != "").ToArray();

            Dictionary<string, Truck> trucksDict = new Dictionary<string, Truck>();
            foreach(var info in trucksInfo)
            {
                string[] truckInfo = info.Split('=').ToArray();
                try
                {
                    trucksDict.Add(truckInfo[0], new Truck(truckInfo[0], int.Parse(truckInfo[1])));
                }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            }

            Dictionary<string, Freight> freightsDict = new Dictionary<string, Freight>();
            foreach (var info in freightsInfo)
            {
                string[] freightInfo = info.Split('=').ToArray();
                try
                {
                    freightsDict.Add(freightInfo[0], new Freight(freightInfo[0], int.Parse(freightInfo[1])));
                }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "END") break; 

                trucksDict[command[0]].LoadFreight(freightsDict[command[1]]);
            }

            foreach (var knownTruck in trucksDict.Values)
            {
                Console.Write($"{knownTruck.Name} - ");

                if (knownTruck.FreightsList.Count() == 0) Console.WriteLine("Nothing loaded");
                else
                { Console.WriteLine(string.Join(", ", knownTruck.FreightsList.Select(f => f.Name))); }
            }
        }
    }
}
