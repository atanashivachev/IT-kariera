using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool m = false;

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    int num = row + col + 1;
                    if (num == n || m == true) { Console.Write(2 * n - num); m = true; }
                    else Console.Write(num);
                }
                Console.WriteLine();
                m = false;
            }
        }
    }
}
