using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryTicket
{
    class LotteryTicketProgram
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[,] matrix = new int[rows, cols];

            FillMatrixFromMatrix(matrix);

            int sumMainDiagonal = 0;
            int sumSecondDiagonal = 0;
            int sumBelowDiagonal = 0;
            int sumAboveDiagonal = 0;

            for (int rUp = 0, rDown = matrix.GetLength(0) - 1; rUp < matrix.GetLength(0); rUp++, rDown--)
            {
                sumMainDiagonal += matrix[rUp, rUp];
                sumSecondDiagonal += matrix[rUp, rDown];

                for (int cUp = rUp + 1, cDown = rUp - 1; cUp < matrix.GetLength(1) || cDown > -1; cUp++, cDown--)
                {
                    if(cUp < matrix.GetLength(1)) sumAboveDiagonal += matrix[rUp, cUp];
                    if(cDown > -1) sumBelowDiagonal += matrix[rUp, cDown];
                }
            }

            if (sumMainDiagonal == sumSecondDiagonal && sumAboveDiagonal % 2 == 0 && sumBelowDiagonal % 2 != 0)
            {
                Console.WriteLine("YES");
                Console.WriteLine($"{profit(matrix, sumBelowDiagonal):F2}");
            }
            else Console.WriteLine("NO");
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
        static double profit(int[,] matrix, int sumBelowDiagonal)
        {
            int sumMainDiagonalEvens = 0;
            int sumEndRowsEvens = 0;
            int sumEndColsOdds = 0;

            for (int up = 0; up < matrix.GetLength(0); up++)
            {
                if(matrix[up, up] % 2 == 0) sumMainDiagonalEvens += matrix[up, up];

                if(matrix[up, 0] % 2 != 0) sumEndColsOdds += matrix[up, 0];
                if(matrix[up, matrix.GetLength(1) - 1] % 2 != 0) sumEndColsOdds += matrix[up, matrix.GetLength(1) - 1];
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[0, i] % 2 == 0) sumEndRowsEvens += matrix[0, i];
                if (matrix[matrix.GetLength(0) - 1, i] % 2 == 0) sumEndRowsEvens += matrix[matrix.GetLength(0) - 1, i];
            }

            return (sumBelowDiagonal + sumMainDiagonalEvens + sumEndRowsEvens + sumEndColsOdds) / 4;
        }
    }
}
