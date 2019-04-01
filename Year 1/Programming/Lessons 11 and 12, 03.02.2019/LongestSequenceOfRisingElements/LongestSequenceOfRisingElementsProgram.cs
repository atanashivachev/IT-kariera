using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequenceOfRisingElements
{
    class LongestSequenceOfRisingElementsProgram
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] repeated = new int[input.Length];

            int seqCont = 0;
            int seqContTemp = 0;

            for (int i = 0; i < input.Length - 2; i++, seqContTemp = 0)
            {
                for (int j = 1; j < input.Length - i; j++)
                {

                    if (input[i] == input[i + j] - j)
                    {
                        seqContTemp++;
                        if (seqContTemp > seqCont)
                        {
                            seqCont = seqContTemp;
                            for (int index = 0, k = i; index <= seqCont; index++, k++)
                            {
                                repeated[index] = input[k];
                            }
                        }
                    }
                }
            }

            Console.WriteLine(repeated[0] + " " + string.Join(" ", repeated.Where(x => x != 0 && x != repeated[0])));
        }
    }
}
