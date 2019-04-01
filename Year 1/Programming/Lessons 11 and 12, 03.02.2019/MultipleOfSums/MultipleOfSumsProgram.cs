using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleOfSums
{
    class MultipleOfSumsProgram
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint k = uint.Parse(Console.ReadLine());

            uint[] sequence = new uint[n];
            sequence[0] = 1;

            for (uint i = 1; i < n; i++)
            {
                if (i < k)
                {
                    for (uint w = 0; w < i; w++)
                    {
                        sequence[i] += sequence[w];
                    }
                }
                else
                {
                    for (uint q = i - k; q < i; q++)
                    {
                        sequence[i] += sequence[q];
                    }
                }
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
