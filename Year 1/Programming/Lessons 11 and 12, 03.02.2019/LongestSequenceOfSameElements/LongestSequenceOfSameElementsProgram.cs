using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequenceOfSameElements
{
    class LongestSequenceOfSameElementsProgram
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] repeated = new int[input.Length];

            int timesRepeated = 0;
            int timesRepeatedTemp = 0;

            for (int i = 0; i < input.Length; i++, timesRepeatedTemp = 0)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        timesRepeatedTemp++;
                        if (timesRepeatedTemp > timesRepeated)
                        {
                            timesRepeated = timesRepeatedTemp;

                            for (int k = 0; k < timesRepeated; k++)
                            {
                                repeated[k] = input[i];
                            }
                        }
                    }
                    else break;
                }
            }

            Console.WriteLine(string.Join(" ", repeated.Where(x => x != 0)));
        }
    }
}
