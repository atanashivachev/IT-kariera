using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10__02._02._2019
{
    class ArrayStatisticsProgram
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int max = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int temp = input[i];
                if (temp > max) max = temp;
            }

            int min = input.Min();
            int sum = input.Sum();
            double average = input.Average();

            Console.WriteLine($"Min = {min}\r\nMax = {max}\r\nSum = {sum}\r\nAverage = {average}");
        }
    }
}
