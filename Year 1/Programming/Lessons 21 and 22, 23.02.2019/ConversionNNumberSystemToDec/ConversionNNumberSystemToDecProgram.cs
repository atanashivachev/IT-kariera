using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionNNumberSystemToDec
{
    class ConversionNNumberSystemToDecProgram
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            double decNum = 0;

            for (int i = 0;input[1] != 0; i++)
            {
                decNum += Math.Pow(input[0], i) * (input[1] % 10);
                input[1] /= 10;
            }

            Console.WriteLine(decNum);
        }
    }
}
