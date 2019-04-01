using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSequenceOfElementsInArray
{
    class ReverseSequenceOfElementsInArrayProgram
    {
        static void Main(string[] args)
        {
            ushort amountOfNumbers = ushort.Parse(Console.ReadLine());
            ushort[] numbers = new ushort[amountOfNumbers];

            for (ushort i = 0; i < amountOfNumbers; i++)
            {
                numbers[amountOfNumbers - i - 1] = ushort.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
