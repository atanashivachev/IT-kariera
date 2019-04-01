using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingOfLogs
{
    class ProcessingOfLogsProgram
    {
        static void Main(string[] args)
        {
            var logs = new SortedDictionary<string, List<string>>();

            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();

                if (logs.ContainsKey(info[1]))
                {
                    logs[info[1]][0] = int.Parse(logs[info[1]][0]) + int.Parse(info[2]) + "";
                    if (!logs[info[1]].Contains(info[0])) logs[info[1]].Add(info[0]);
                }
                else
                {
                    logs.Add(info[1], new List<string> { info[2], info[0]});
                }
            }

            foreach (var pair in logs)
            {
                Console.Write($"{pair.Key}: {pair.Value[0]} [");
                Console.Write(string.Join(", ", pair.Value.Skip(1).OrderBy(x => x)));
                Console.WriteLine(']');
            }
        }
    }
}
