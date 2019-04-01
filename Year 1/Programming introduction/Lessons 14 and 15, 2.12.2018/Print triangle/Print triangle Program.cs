using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            UpperHalf(n);
            LowerHalf(n);
        }
        static void UpperHalf(int n)
        {
            int g = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(g + " ");
                    g++;
                }
                g = 1;
                Console.WriteLine();
            }

        }
        static void LowerHalf(int n)
        {
            int g = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(g + " ");
                    g++;
                }
                g = 1;
                Console.WriteLine();
            }
        }
    }
}
