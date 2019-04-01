using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter
{
    class OddFilterProgram
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).Where(x => x % 2 == 0).ToArray();

            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] <= Math.Ceiling(input.Average())) input[i]--;
                else input[i]++;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
