using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class UserLogsProgram
    {
        static void Main(string[] args)
        {
            var userLogs = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('=', ' ').Where(x => x != "").ToArray(); ;
                if (input[0].Equals("end")) break;

                if (userLogs.ContainsKey(input[5]))
                {
                    if (userLogs[input[5]].ContainsKey(input[1])) userLogs[input[5]][input[1]] += 1;
                    else userLogs[input[5]].Add(input[1], 1);
                }
                else
                {
                    userLogs.Add(input[5], new Dictionary<string, int>());
                    userLogs[input[5]].Add(input[1], 1);
                }
            }

            foreach (var pair in userLogs.OrderBy(x => x.Key))
            {
                Console.WriteLine(pair.Key + ':');
                foreach (var ips in pair.Value)
                {
                    Console.Write($"{ips.Key} => {ips.Value}");
                    if (!pair.Value.Last().Equals(ips)) Console.Write(", ");
                }
                Console.WriteLine('.');
            }
        }
    }
}
