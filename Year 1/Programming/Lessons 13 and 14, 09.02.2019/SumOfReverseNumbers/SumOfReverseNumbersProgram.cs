using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfReverseNumbers
{
    class SumOfReverseNumbersProgram
    {
        static void Main(string[] args)
        {
            List<String> input = Console.ReadLine().Split(' ').ToList();
            int sum = 0;

            foreach (String num in input)
            {
                string reverseNum = new string(num.Reverse().ToArray());
                sum += int.Parse(reverseNum); 
            }

            Console.WriteLine(sum);
        }
    }
}
