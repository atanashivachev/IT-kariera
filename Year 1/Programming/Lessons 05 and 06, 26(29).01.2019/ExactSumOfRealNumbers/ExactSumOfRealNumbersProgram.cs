using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumOfRealNumbers
{
    class ExactSumOfRealNumbersProgram
    {
        static void Main(string[] args)
        {
            uint amountOfNumbers = uint.Parse(Console.ReadLine());
            decimal sum = 0;

            for (uint i = 0; i < amountOfNumbers; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
