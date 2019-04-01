using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raindrops
{
    class RaindropsProgram
    {
        static void Main(string[] args)
        {
            Byte regions = Byte.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());

            double regionalCoefficients = 0L;
            for (Byte i = 0; i < regions; i++)
            {
                long[] info = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                regionalCoefficients += info[0] * 1.0 / info[1];
            }

            if (density == 0) Console.WriteLine($"{regionalCoefficients:F3}");
            else Console.WriteLine($"{regionalCoefficients / density:F3}");
        }
    }
}
