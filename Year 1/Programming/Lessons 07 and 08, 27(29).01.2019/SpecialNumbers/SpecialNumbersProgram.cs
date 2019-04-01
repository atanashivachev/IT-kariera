using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbersProgram
    {
        static void Main(string[] args)
        {
            uint maxNum = uint.Parse(Console.ReadLine());

            for (uint i = 1; i <= maxNum; i++)
            {
                uint sumOfDigits = SumOfDigitsMethod(i);
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} --> True");
                }
                else
                {
                    Console.WriteLine($"{i} --> False");
                }
            }
        }
        static uint SumOfDigitsMethod(uint i)
        {
            uint sum = 0;
            uint temp = 0;

            while (i != 0)
            {
                temp = i % 10;
                sum += temp;
                i /= 10;
            }

            return sum;
        }
    }
}
