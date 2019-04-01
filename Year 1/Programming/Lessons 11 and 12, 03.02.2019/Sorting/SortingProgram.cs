using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class SortingProgram
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //i e nashata poziciq, k e poziciqta na nai-malkata cifra v algorituma, j sravnqva cifra v
            //poziciq i sus vsqka sledvashta poziciq
            for (int i = 0; i < input.Length; i++)
            {
                int k = i;

                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] < input[k]) k = j;
                }
                int swapVar = input[i];
                input[i] = input[k];
                input[k] = swapVar;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
