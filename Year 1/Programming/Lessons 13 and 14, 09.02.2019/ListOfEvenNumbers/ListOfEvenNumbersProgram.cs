using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEvenNumbers
{
    class ListOfEvenNumbersProgram
    {
        static void Main(string[] args)
        {
            List<Int32> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var evenNumbers = new List<Int32>();

            foreach (int num in input)
            {
                if (num % 2 == 0) evenNumbers.Add(num);
            }

            Console.WriteLine(string.Join(" ", evenNumbers));
        }
    }
}
