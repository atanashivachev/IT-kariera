using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_odd_sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int sumE = 0;
            int sumO = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (i % 2 == 0) sumE += num;
                else sumO += num;
            }
            if (sumO == sumE) { Console.WriteLine("Yes"); Console.WriteLine($"Sum = {sumO}"); }
            else {Console.WriteLine("No"); Console.WriteLine($"Diff = {Math.Abs(sumO - sumE)}");}
        }
    }
}
