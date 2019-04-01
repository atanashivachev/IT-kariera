using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_others
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int n = 0;
            int big = int.MinValue;
            int sum = 0;

            for (int i = 0; i < a; i++)
            {
                n = int.Parse(Console.ReadLine());
                sum += n;
                if (n > big) big = n; 
            }
            sum -= big;
            if (big == sum) { Console.WriteLine("Yes"); Console.WriteLine($"Sum = {sum}"); }
            else { Console.WriteLine("No"); Console.WriteLine($"Diff = {Math.Abs(big - sum)}"); }
        }
    }
}
