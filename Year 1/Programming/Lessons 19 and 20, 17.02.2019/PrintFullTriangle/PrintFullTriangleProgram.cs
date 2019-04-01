using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFullTriangle
{
    class PrintFullTriangleProgram
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            TopBottomPart(input);
            MiddlePart(input);
            TopBottomPart(input);
        }
        static void TopBottomPart(int length)
        {
            Console.WriteLine(new string('-', length * 2));
        }
        static void MiddlePart(int length)
        {
            for (int j = 0; j < length / 2; j++)
            {
                Console.Write("-");

                for (int i = 0; i < length - 1; i++) Console.Write("\\/");

                Console.WriteLine("-");
            }
        }
    }
}
