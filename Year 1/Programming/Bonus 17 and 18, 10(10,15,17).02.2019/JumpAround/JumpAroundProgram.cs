using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpAround
{
    class JumpAroundProgram
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int jumpIndex = 0;
            int jumpSum = input[jumpIndex];

            for (; ; )
            {
                if (input[jumpIndex] + jumpIndex <= input.Count - 1)
                {
                    jumpIndex += input[jumpIndex];
                }
                else if (jumpIndex - input[jumpIndex] >= 0)
                {
                    jumpIndex -= input[jumpIndex];
                }
                else break;
                jumpSum += input[jumpIndex];
            }

            Console.WriteLine(jumpSum);
        }
    }
}
