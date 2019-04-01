using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchElementInSortedArray
{
    class SearchElementInSortedArrayProgram
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int search = int.Parse(Console.ReadLine());
            string found = "No";

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] == search) found = "Yes";
            }

            Console.WriteLine(found);
        }
    }
}
