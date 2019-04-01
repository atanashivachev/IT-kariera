using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class PascalTriangleProgram
    {
        static void Main(string[] args)
        {
            //gave up
            int size = int.Parse(Console.ReadLine());
            long[][] triangle = new long[size + 1][];

            for (int row = 0; row < size; row++)
            {
                triangle[row] = new long[row + 1];
            }

            triangle[0][0] = 1;

            for (int row = 0; row < size - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            WriteMatrix(triangle);
        }
        static void WriteMatrix(long[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
