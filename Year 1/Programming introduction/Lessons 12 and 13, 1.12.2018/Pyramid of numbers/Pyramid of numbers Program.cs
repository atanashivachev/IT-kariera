using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 0;

            for (int i = 1; p != n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    p += 1;
                    Console.Write($"{p} ");
                    if (p == n) break;
                }
                Console.WriteLine();               
            }
        }
    }
}
