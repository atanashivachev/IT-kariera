using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumber
{
    class FindNumberProgram
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] tasks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            input.RemoveRange(tasks[0], input.Count - tasks[0]);
            input.RemoveRange(0, tasks[1]);

            if (input.Contains(tasks[2])) Console.WriteLine("YES!");
            else Console.WriteLine("NO!");

        }
    }
}
