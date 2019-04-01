using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raise_to_power
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPow(n, p));
        }
        static double RaiseToPow(double n, double p)
        {
            double result = 1;
            for (double i = 0; i < p; i++)
            {
                result *= n;
            }
            return result;
        }
    }
}
