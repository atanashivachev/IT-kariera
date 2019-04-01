using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string nuMber = Console.ReadLine();
            int number = int.Parse(nuMber);
            int d1 = nuMber[0] - 48;
            int d2 = nuMber[1] - 48;
            int d3 = nuMber[2] - 48;

            int row = d1 + d2;
            int col = d1 + d3;

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (number % 5 == 0) number -= d1;
                    else if (number % 3 == 0) number -= d2;
                    else number += d3;

                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
