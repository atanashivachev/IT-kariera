using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Compaire(n);
        }
        static void Compaire(int n)
        {
            if (n < 0) Negative(n);
            else if (n > 0) Positive(n);
            else Zero();
        }
        static void Negative(int n)
        {
            Console.WriteLine($"The number {n} is negative.");
        }
        static void Positive(int n)
        {
            Console.WriteLine($"The number {n} is positive.");
        }
        static void Zero()
        {
            Console.WriteLine($"The number 0 is zero.");
        }
    }
}
