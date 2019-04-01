using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfSameDigits
{
    class MaxSequenceOfSameDigitsProgram
    {
        static void Main(string[] args)
        {
            List<Int32> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var repeatedList = new List<Int32>();

            int tempRepeated = 0;
            int repeated = 0;

            for (int k = 0; k < input.Count; k++, tempRepeated = 0)
            {
                for (int i = k; i < input.Count - 1; i++)
                {
                    if (input[i] == input[k])
                    {
                        tempRepeated++;
                        if (tempRepeated > repeated)
                        {
                            repeated = tempRepeated;
                            repeatedList.Clear();

                            for (int j = 0; j < repeated; j++)
                            {
                                repeatedList.Add(input[i]);
                            }
                        }
                    }
                    else break;
                }
            }

            Console.WriteLine(string.Join(" ", repeatedList));
        }
    }
}
