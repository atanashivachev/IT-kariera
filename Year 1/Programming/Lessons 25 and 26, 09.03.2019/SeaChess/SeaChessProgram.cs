using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaChess
{
    class SeaChessProgram
    {
        static void Main(string[] args)
        {
            char[,] game = new char[3, 3];
            FillMatrixFromMatrix(game);
            bool foundWinner = false;


            for (int j = 0; j < 3 && !foundWinner; j++)
            {
                if (game[0, j] == 'O' && game[1, j] == 'O' && game[2, j] == 'O') { Console.WriteLine("The winner is: O"); foundWinner = true; break; }
                else if (game[0, j] == 'X' && game[1, j] == 'X' && game[2, j] == 'X') { Console.WriteLine("The winner is: X"); foundWinner = true; break; }
                else if (game[j, 0] == 'O' && game[j, 1] == 'O' && game[j, 2] == 'O') { Console.WriteLine("The winner is: O"); foundWinner = true; break; }
                else if (game[j, 0] == 'X' && game[j, 1] == 'X' && game[j, 2] == 'X') { Console.WriteLine("The winner is: X"); foundWinner = true; break; }
            }

            if (!foundWinner)
            {
                if(game[0,0] == 'O' && game[1,1] == 'O' && game[2,2] == 'O') { Console.WriteLine("The winner is: O"); foundWinner = true; }
                else if (game[2,0] == 'O' && game[1,1] == 'O' && game[0,2] == 'O') { Console.WriteLine("The winner is: O"); foundWinner = true; }
                else if (game[0, 0] == 'X' && game[1, 1] == 'X' && game[2, 2] == 'X') { Console.WriteLine("The winner is: X"); foundWinner = true; }
                else if (game[2, 0] == 'X' && game[1, 1] == 'X' && game[0, 2] == 'X') { Console.WriteLine("The winner is: X"); foundWinner = true; }
            }

            if (!foundWinner) Console.WriteLine("There is no winner");
        }

        static void FillMatrixFromMatrix(char[,] game)
        {
            for (int i = 0; i < 3; i++)
            {
                char[] input = Console.ReadLine().Split(' ').Select(x => x.First()).ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    game[i, j] = input[j];
                }
            }
        }
    }
}
