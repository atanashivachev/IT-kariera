using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineSortedArrays
{
    class CombineSortedArraysProgram
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] combined = new int[array1.Length + array2.Length];

            array1.CopyTo(combined, 0); array2.CopyTo(combined, array1.Length);

            //insertion sort algorithm
            for (int i = 0; i < combined.Length; i++)
            {
                int swap = combined[i];
                int index = i;

                while (index > 0 && combined[index - 1] >= swap)
                {
                    combined[index] = combined[index - 1];
                    index--;
                }
                combined[index] = swap;
            }

            Console.WriteLine(string.Join(" ", combined));
        }
    }
}
