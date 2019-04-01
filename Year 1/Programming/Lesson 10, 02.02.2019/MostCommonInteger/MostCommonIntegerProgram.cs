using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostCommonInteger
{
    class MostCommonIntegerProgram
    {
        static void Main(string[] args)
        {
            ushort[] input = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            ushort repeated = 0;
            ushort repeatedInt = 0;
            ushort tempRepeated = 0;

            for (ushort i = 0; i < input.Length; i++, tempRepeated = 0)
            {
                for (ushort j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        tempRepeated++;
                        if (tempRepeated > repeated) { repeated = tempRepeated; repeatedInt = input[j]; }
                    }                   
                }              
            }

            Console.WriteLine($"Ushort {repeatedInt} was repeated {repeated} times.");
        }
    }
}
