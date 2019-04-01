using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thief
{
    class ThiefProgram
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            byte row = byte.Parse(Console.ReadLine());
            long max = 0;

            switch (type)
            {
                case "sbyte": max = sbyte.MaxValue; break;
                case "int": max = int.MaxValue; break;
                case "long": max = long.MaxValue; break;
            }

            long biggest = 0;

            for (byte i = 0; i < row; i++)
            {
                long n = long.Parse(Console.ReadLine());
                if (n < max && biggest < n) biggest = n;
            }

            Console.WriteLine(biggest);
        }
    }
}
