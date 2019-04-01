using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingOfNumbersWithAffixAndPrefix
{
    class ProcessingOfNumbersWithAffixAndPrefixProgram
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
            double sum = 0;

            //the task specifies time, less than 0.3 seconds, so you can test the time by uncommenting the stopwatch (the count of strings is maximum 10)
            //DON'T FORGET TO ADD System.Diagnostics IF YOU WANT TO TEST CODE SPEED!
            //Article for stopwatch: https://www.dotnetperls.com/stopwatch

            //with  P34562Z q2576f   H456z P34562Z q2576f   H456z P34562Z q2576f   H456z P34562Z  the code finished in 00:00:00.0000504

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            for (int i = 0; i < input.Length; i++)
            {
                double num = int.Parse(input[i].Substring(1, input[i].Length - 2));

                char firstLetter = input[i][0];
                char lastLetter = input[i][input[i].Length - 1];

                if (firstLetter > 64 && firstLetter < 91) num /= firstLetter - 64;
                else num *= input[i][0] - 96;

                if (lastLetter > 64 && lastLetter < 91) num -= lastLetter - 64;
                else num += lastLetter - 96;

                sum += num;
            }

            //stopwatch.Stop();

            Console.WriteLine($"{sum:F2}");
            //Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
