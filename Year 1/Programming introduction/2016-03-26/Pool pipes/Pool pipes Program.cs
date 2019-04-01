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
                double x = Math.Floor((filled / V) * 100);
                double y = Math.Floor((pipe1 / filled) * 100);
                double z = Math.Floor((pipe2 / filled) * 100);

                Console.WriteLine($"The pool is {x}% full. Pipe 1: {y}%. Pipe 2: {z}%.");
            }
            else
            {
                double y = Math.Round(filled - V, 2);
                Console.WriteLine($"For {N} hours the pool overflows with {y} liters.");
            }
        }
    }
}
