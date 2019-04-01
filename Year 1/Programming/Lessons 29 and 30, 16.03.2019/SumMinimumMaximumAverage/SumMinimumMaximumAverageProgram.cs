using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinimumMaximumAverage
{
    class SumMinimumMaximumAverageProgram
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            var nums = new List<int>();

            for (int i = 0; i < length; i++)
            { nums.Add(int.Parse(Console.ReadLine()));}

            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Average = {nums.Average()}");
        }
    }
}
