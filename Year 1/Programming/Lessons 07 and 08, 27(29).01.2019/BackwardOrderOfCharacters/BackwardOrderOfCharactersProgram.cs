using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackwardOrderOfCharacters
{
    class BackwardOrderOfCharactersProgram
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}\r\n{1}\r\n{2}", ch3, ch2, ch1);
        }
    }
}
