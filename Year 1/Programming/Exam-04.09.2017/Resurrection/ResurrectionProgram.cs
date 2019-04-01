using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class ResurrectionProgram
    {
        static void Main(string[] args)
        {
            ushort phoenixes = ushort.Parse(Console.ReadLine());

            for (ushort i = 0; i < phoenixes; i++)
            {
                int bodyLength = int.Parse(Console.ReadLine());
                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                int wingLength = int.Parse(Console.ReadLine());

                Console.WriteLine(Convert.ToDecimal(Math.Pow(bodyLength, 2)) * (bodyWidth + 2 * wingLength));
            }
        }
    }
}
