using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumArea
{
    class MaximumAreaProgram
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] square = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int[] nums = Console.ReadLine().Split(' ').Select(x => int.Parse(x + "")).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    square[j, i] = nums[j];
                }
            }

            int[,] twoTwo = new int[2, 2];
            int maxSum = 0;
            for (int i = 0; i < cols - 1; i++)
            {
                for (int j = 0; j < rows - 1; j++)
                {
                    if (square[i, j] + square[i, j + 1] + square[i + 1, j] + square[i + 1, j + 1] > maxSum)
                    {
                        maxSum = square[i, j] + square[i, j + 1] + square[i + 1, j] + square[i + 1, j + 1];

                        twoTwo[0, 0] = square[i, j];
                        twoTwo[0, 1] = square[i, j + 1];
                        twoTwo[1, 0] = square[i + 1, j];
                        twoTwo[1, 1] = square[i + 1, j + 1];
                    }
                }
            }

            Console.WriteLine(twoTwo[0,0] + " " + twoTwo[1,0]);
            Console.WriteLine(twoTwo[0,1] + " " + twoTwo[1,1]);

        }
    }
}
