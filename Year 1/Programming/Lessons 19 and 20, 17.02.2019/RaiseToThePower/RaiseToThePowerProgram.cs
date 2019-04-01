using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaiseToThePower
{
    class RaiseToThePowerProgram
    {
        static void Main(string[] args)
        {
            double baseInt = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(Powered(baseInt, power));
        }
        static double Powered(double baseInt, double power)
        {
            return Math.Pow(baseInt, power);
        }
    }
}
