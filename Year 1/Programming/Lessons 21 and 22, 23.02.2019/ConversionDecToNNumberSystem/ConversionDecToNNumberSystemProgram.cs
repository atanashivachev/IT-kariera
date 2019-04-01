using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionDecToNNumberSystem
{
    class ConversionDecToNNumberSystemProgram
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var convtedInt = new List<int>();

            while (input[1] != 0)
            {
                convtedInt.Add(input[1] % input[0]);
                input[1] /= input[0];
            }

            convtedInt.Reverse();
            Console.WriteLine(string.Join("", convtedInt));
        }
    }
}
