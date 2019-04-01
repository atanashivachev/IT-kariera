using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConnection
{
    class StringConnectionProgram
    {
        static void Main(string[] args)
        {
            char divisor = Console.ReadLine()[0];
            string evenOdd = Console.ReadLine();
            byte rows = byte.Parse(Console.ReadLine());

            string sentence = null;

            for (byte i = 1; i <= rows; i++)
            {
                string word = Console.ReadLine();
                if (evenOdd == "even")
                {
                    if (i % 2 == 0)
                    {
                        sentence += word;
                        if (i != rows - 1) sentence += divisor;
                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        sentence += word;
                        if (i != rows - 1) sentence += divisor;
                    }
                }
            }

            Console.WriteLine(sentence);
        }
    }
}
