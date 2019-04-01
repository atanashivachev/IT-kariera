using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1, f1 = 1;

            if (n < 2);
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    int oldF = f1;
                    f1 = oldF + f0;
                    f0 = oldF; 
                }
            }
            Console.WriteLine(f1);
        }
    }
}
