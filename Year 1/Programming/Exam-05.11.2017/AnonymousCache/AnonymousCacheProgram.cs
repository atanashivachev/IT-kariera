using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCache
{
    class AnonymousCacheProgram
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<string>>();
            //dictionary key = dataSet, dataSize = data[0]
            var cache = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ', '-', '>', '|').Where(x => x != "").ToArray();

                if (command.Length == 1)
                {
                    if (command[0] != "thetinggoesskrra")
                    {
                        if (cache.ContainsKey(command[0])) data.Add(command[0], cache[command[0]]);
                        else data.Add(command[0], new List<string> { "0", null });
                    }
                    else break;
                }
                else
                {
                    if (data.ContainsKey(command[2]))
                    {
                        data[command[2]][0] = "" + (long.Parse(data[command[2]][0]) + long.Parse(command[1]));
                        data[command[2]].Add(command[0]);
                    }
                    else
                    {
                        if (cache.ContainsKey(command[2]))
                        {
                            cache[command[2]][0] = "" + (long.Parse(cache[command[2]][0]) + long.Parse(command[1]));
                            cache[command[2]].Add(command[0]);
                        }
                        else cache.Add(command[2], new List<string> { command[1], command[0] });
                    }
                }
            }

            string mostDataSet = data.Keys.First();
            foreach (var pair in data)
            {
                if (long.Parse(data[pair.Key][0]) > long.Parse(data[mostDataSet][0])) mostDataSet = pair.Key;
            }

            Console.WriteLine($"Data Set: {mostDataSet}, Total Size: {data[mostDataSet][0]}");
            for (int i = 1; i < data[mostDataSet].Count; i++)
            {
                if(data[mostDataSet][i] != null) Console.WriteLine($"$.{data[mostDataSet][i]}");
            }
        }
    }
}
