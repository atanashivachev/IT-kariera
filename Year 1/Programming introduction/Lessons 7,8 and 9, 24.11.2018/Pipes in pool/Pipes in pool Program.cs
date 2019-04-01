using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes_in_pool
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            double P1 = double.Parse(Console.ReadLine());
            double P2 = double.Parse(Console.ReadLine());
            double N = double.Parse(Console.ReadLine());

            double pipe1 = P1 * N;
            double pipe2 = P2 * N;
            double filled = pipe1 + pipe2;

            if (filled <= V)
            {
                double x = (filled / V) * 100;
                double y = (pipe1 / filled) * 100;
                double z = (pipe2 / filled) * 100;

                Console.WriteLine($"The pool is {x:F0} % full.Pipe 1: {y:F0} %.Pipe 2: {z:F0}%.");
            }
            else
            {
                double y = filled - V;
                Console.WriteLine($"For {N} hours the pool overflows with {y:F1} liters.");
            }
        }
    }
}
