using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertElementInSortedArray
{
    class InsertElementInSortedArrayProgram
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] finalArray = new int[inputArray.Length + 1];
            inputArray.CopyTo(finalArray, 1);
            finalArray[0] = int.Parse(Console.ReadLine());

            //bubble sorting algorithm, to exercise with sorting algorithms

            for (int j = 0; j < finalArray.Length - 1; j++)
            {
                for (int i = 0; i < finalArray.Length - 1; i++)
                {
                    if (finalArray[i] > finalArray[i + 1])
                    {
                        var temp = finalArray[i];
                        finalArray[i] = finalArray[i + 1];
                        finalArray[i + 1] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", finalArray));
        }
    }
}
