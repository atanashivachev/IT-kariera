using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTriangle
{
    class PrintTriangleProgram
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            TriangleTop(input);
            TriangleBottom(input);
        }
        static void TriangleTop(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        static void TriangleBottom(int length)
        {
            for (int i = length - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
