using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAWord
{
    class MakeAWordProgram
    {
        static void Main(string[] args)
        {
            byte rows = byte.Parse(Console.ReadLine());
            string word = null;

            for (byte i = 0; i < rows; i++)
            {
                char letter = Console.ReadLine()[0];
                word += letter;
            }
            Console.WriteLine($"The words is: {word}");
        }
    }
}
