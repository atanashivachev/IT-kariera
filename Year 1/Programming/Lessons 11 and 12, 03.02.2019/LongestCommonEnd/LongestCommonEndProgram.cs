using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonEnd
{
    class LongestCommonEndProgram
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');

            int repeatedLR = 0;
            int repeatedRL = 0;

            // chetene ot lqvo na dqsno
            for (int i = 0; i < Math.Min(input1.Length, input2.Length); i++)
            {
                if (input1[i] == input2[i]) repeatedLR++;
                else break;
            }

            //chetene ot dqsno na lqvo
            Array.Reverse(input1); Array.Reverse(input2);
            for (int i = 0; i < Math.Min(input1.Length, input2.Length); i++)
            {
                if (input1[i] == input2[i]) repeatedRL++;
                else break;
            }

            Console.WriteLine(Math.Max(repeatedLR, repeatedRL));
        }
    }
}
