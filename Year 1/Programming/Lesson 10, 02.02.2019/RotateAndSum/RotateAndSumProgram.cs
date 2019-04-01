using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class RotateAndSumProgram
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array1 = new int[input.Length];

            int[] arraySum = new int[input.Length];
            Array.Copy(input, 0, arraySum, 1, input.Length - 1);
            arraySum[0] = input[input.Length - 1];

            int rotate = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotate; i++)
            {
                Array.Copy(input, 0, array1, 1, input.Length - 1);
                array1[0] = input[input.Length - 1];

                if (i != 0) for (int j = 0; j < array1.Length; j++) { arraySum[j] += array1[j]; }

                Array.Copy(array1, 0, input, 0, input.Length);
            }

            Console.WriteLine(string.Join(" ", arraySum));
        }
    }
}
