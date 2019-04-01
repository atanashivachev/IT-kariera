using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyStrings
{
    class MultiplyStringsProgram
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string input1 = input[0];
            string input2 = input[1];

            int shortestString = Math.Min(input1.Length, input2.Length);
            int longestString = Math.Max(input1.Length, input2.Length);
            //in the code there really isn't need to keep max and min values in int, but technically, in practice the for cycle could run for a long time, so int comparison is faster than repeating computation

            bool in1IsLonger = true;
            if (longestString == input2.Length) in1IsLonger = false;
    
            int sum = 0;

            for (int i = 0; i < longestString; i++)
            {
                if (i < shortestString) sum += input1[i] * input2[i];
                else
                {
                    if (in1IsLonger == true) sum += input1[i];
                    else sum += input2[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
