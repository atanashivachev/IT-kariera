using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripletOfLetters
{
    class TripletOfLettersProgram
    {
        static void Main(string[] args)
        {
            byte letter = byte.Parse(Console.ReadLine());
            letter += 97;

            for (byte i = 97; i < letter; i++)
            {
                for (byte j = 97; j < letter; j++)
                {
                    for (byte l = 97; l < letter; l++)
                    {
                        Console.WriteLine($"{(char)(i)}{(char)(j)}{(char)(l)}");
                    }
                }
            }
        }
    }
}
