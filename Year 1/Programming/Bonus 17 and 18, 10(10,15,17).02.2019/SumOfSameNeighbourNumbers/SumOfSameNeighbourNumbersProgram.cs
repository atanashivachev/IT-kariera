using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSameNeighbourNumbers
{
    class SumOfSameNeighbourNumbersProgram
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0, length = input.Count; i < length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input[i] *= 2;
                    input.RemoveAt(i + 1);
                    length--;
                    i = -1;           
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
