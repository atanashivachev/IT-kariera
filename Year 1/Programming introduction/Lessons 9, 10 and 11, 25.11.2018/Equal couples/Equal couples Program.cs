using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_couples
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum1 = a + b;
            int sum = 0;
            int diff = 0;

            for (int i = 0; i < n - 1; i++)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                sum = a + b;
                if (sum1 == sum) { }
                else { diff = Math.Abs(sum1 - sum); sum1 = sum; }
            }

            if (diff == 0) Console.WriteLine($"Yes, value = {sum1}");
            else Console.WriteLine($"No, maxdiff={diff}");
        }
    }
}
