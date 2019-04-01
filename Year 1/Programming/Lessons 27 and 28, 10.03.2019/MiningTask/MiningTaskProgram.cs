using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningTask
{
    class MiningTaskProgram
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop") break;

                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource)) resources.Add(resource, quantity);
                else resources[resource] += quantity;
            }

            DictionaryPrint(resources);
        }

        static void DictionaryPrint(Dictionary<string, int> dict)
        {
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
