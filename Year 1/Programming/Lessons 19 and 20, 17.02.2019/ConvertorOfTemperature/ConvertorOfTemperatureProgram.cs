using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorOfTemperature
{
    class ConvertorOfTemperatureProgram
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine($"{ConvertToCel(input):F2}");
        }
        static double ConvertToCel(double fahr)
        {
            return (fahr - 32) * 5 / 9;
        }
    }
}
