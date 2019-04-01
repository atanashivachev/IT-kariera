using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 2;
            int b = n - 2;

            Console.WriteLine(new string(' ', n - 1) + "*");
            for (int i = 1; i < n - 1; i++)
            {
                for (int g = 0; g < b - 1; g++) Console.Write(" ");
                for (int t = 0; t < a; t++) Console.Write(" *");
                a += 1;
                b -= 1;
                Console.WriteLine();
            }
            Console.Write("*");
            for (int p = 0; p < n - 1; p++) Console.Write(" *");
            Console.WriteLine();

            a -= 1;
            b = 1;

            for (int i = 1; i < n - 1; i++)
            {
                for (int g = 0; g < b - 1; g++) Console.Write(" ");
                for (int t = 0; t < a; t++) Console.Write(" *");
                a -= 1;
                b += 1;
                Console.WriteLine();
            }
            Console.WriteLine(new string(' ', n - 1) + "*");
        }
    }
}
