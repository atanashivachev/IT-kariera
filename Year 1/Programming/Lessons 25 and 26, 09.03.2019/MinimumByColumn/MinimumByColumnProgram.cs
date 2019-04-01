using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumByColumn
{
    class MinimumByColumnProgram
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            FillMatrixFromMatrix(matrix);

            WriteMatrix(matrix);

            int[] smallestNums = new int[matrix.GetLength(1)];
            
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int small = matrix[0, i];

                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    int temp = matrix[j, i];
                    if (temp < small) small = temp;
                }
                smallestNums[i] = small;
            }

            Console.WriteLine(string.Join(" ", smallestNums));
        }

        static void FillMatrixFromMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
        }
        static void WriteMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
