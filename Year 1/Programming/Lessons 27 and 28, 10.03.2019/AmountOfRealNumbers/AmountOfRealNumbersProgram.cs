using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmountOfRealNumbers
{
    class AmountOfRealNumbersProgram
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var realNums = new SortedDictionary<double, int>();

            foreach (var num in input)
            {
                if (!realNums.ContainsKey(num)) realNums.Add(num, 1);
                else realNums[num] += 1;
            }

            DictionaryPrint(realNums);
        }

        static void DictionaryPrint(SortedDictionary<double, int> dict)
        {
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
