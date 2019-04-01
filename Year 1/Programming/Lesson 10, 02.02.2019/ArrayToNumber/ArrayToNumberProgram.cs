using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayToNumber
{
    class ArrayToNumberProgram
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] couples = new int[input.Length - 1];

            if (input.Length == 1) couples = input;

            for (; ; )
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    couples[i] = input[i] + input[i + 1];
                }
                input = couples;
                if (couples.Length == 1) break;
                couples = new int[input.Length - 1];
            }

            Console.WriteLine(couples.Single());
        }
    }
}
