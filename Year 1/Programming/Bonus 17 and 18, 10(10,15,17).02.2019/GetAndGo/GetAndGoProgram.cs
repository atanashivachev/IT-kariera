using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAndGo
{
    class GetAndGoProgram
    {
        static void Main(string[] args)
        {
             List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());
            int timesRep = 0;

            int rep = 0;
            foreach (int number in input) { if (number == num) rep++; }

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == num) timesRep++;

                if (timesRep == rep)
                {
                    input.RemoveRange(i, input.Count - i);
                    break;
                }
            }

            if (timesRep != 0) Console.WriteLine(input.Sum());
            else Console.WriteLine("No occurrences were found!");
        }
    }
}
