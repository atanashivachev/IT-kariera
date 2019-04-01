using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverflowingWater
{
    class OverFlowingProgram
    {
        static void Main(string[] args)
        {
            byte row = byte.Parse(Console.ReadLine());
            int totalLiters = 0;

            for (byte i = 0; i < row; i++)
            {
                ushort liters = ushort.Parse(Console.ReadLine());
                totalLiters += liters;
                if (totalLiters > 255) { Console.WriteLine("Insufficient capacity!"); totalLiters -= liters; }
            }
            Console.WriteLine(totalLiters);
        }
    }
}
