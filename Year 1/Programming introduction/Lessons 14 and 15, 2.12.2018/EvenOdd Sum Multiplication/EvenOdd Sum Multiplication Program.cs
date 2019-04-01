using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd_Sum_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(SumOfEven(n) * SumOfOdd(n));
        }
        static int SumOfEven(int n)
        {
            int sum = 0;
            for (; ; )
            {
                if (n == 0) break;
                int num = n % 10;                
                if (num % 2 == 0) sum += num;
                n /= 10;
            }
            return sum;
        }
        static int SumOfOdd(int n)
        {
            int sum = 0;
            int p = 1;
            for (; ; )
            {
                if (n == 0) break;
                int num = n % 10 * p;
                if (num % 2 != 0) sum += num;
                n /= 10;
            }
            return sum;
        }
    }
}
