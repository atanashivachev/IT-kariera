using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2___3_SqrtRequest
{
    static class Sqrt
    {
        private static double[] sqrts = new double[1001];
        
        static Sqrt()
        {
            for(int i = 0; i < sqrts.Length; i++)
            {
                sqrts[i] = Math.Sqrt(i);
            }
        }

        public static void Request(int num)
        {
            if (num < 1 || num > 1000)
            { throw new ArgumentException("Number must be in the interval [1; 1000]."); }

            Console.WriteLine($"Sqaure root of {num} is {sqrts[num]}");
        }
    }
}
