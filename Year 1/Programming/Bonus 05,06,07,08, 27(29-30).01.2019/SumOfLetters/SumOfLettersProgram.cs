using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfLetters
{
    class SumOfLettersProgram
    {
        static void Main(string[] args)
        {
            byte rows = byte.Parse(Console.ReadLine());
            uint sum = 0;

            for (byte i = 0; i < rows; i++)
            {
                char letter = Console.ReadLine()[0];
                sum += letter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
