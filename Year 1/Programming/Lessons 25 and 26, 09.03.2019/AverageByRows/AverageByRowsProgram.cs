using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageByRows
{
    class AverageByRowsProgram
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            FillMatrix(matrix);

            for (int i = 0; i < rows; i++)
            {
                double sum = 0;

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    sum += matrix[i, j];
                }
                Console.WriteLine($"{sum / cols:F2}");
            }
        }

        static void FillMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
