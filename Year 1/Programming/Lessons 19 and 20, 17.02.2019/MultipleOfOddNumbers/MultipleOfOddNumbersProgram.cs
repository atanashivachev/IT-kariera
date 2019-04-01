using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleOfOddNumbers
{
    class MultipleOfOddNumbersProgram
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Select(x => Convert.ToString(x)).
                Where(x => x == "0" || x == "1" || x =="2" || x == "3" || x == "4" || x == "5" || x == "6" || x == "7" || x == "8" || x == "9").
                Select(int.Parse).Select(Math.Abs).ToList();

            List<int> odds = input.Where(x => x % 2 != 0).ToList();
            List<int> even = input.Where(x => x % 2 == 0).ToList();

            Console.WriteLine(odds.Sum() * even.Sum());
        }
    }
}
