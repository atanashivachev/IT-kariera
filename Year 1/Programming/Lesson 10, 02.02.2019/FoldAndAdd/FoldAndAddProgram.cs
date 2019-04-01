using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndAdd
{
    class FoldAndAddProgram
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = input.Length;

            int[] edgeNumbers = new int[input.Length / 2];
            int edgeElement = 0;
            int[] middleNumbers = new int[input.Length / 2];
            int midElement = 0;
            int[] sum = new int[input.Length / 2];

            for (int i = 0; i < length; i++)
            {
                if (i <= length / 4 - 1) { edgeNumbers[edgeElement] = input[length / 4 - 1 - i]; edgeElement++; }
                else if (i > length - length / 4 - 1) { edgeNumbers[edgeElement] = input[length - (i - length*3/4) - 1]; edgeElement++; }
                else { middleNumbers[midElement] = input[i]; midElement++; }
            }

            for (int i = 0; i < edgeNumbers.Length; i++) { sum[i] = edgeNumbers[i] + middleNumbers[i]; }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
