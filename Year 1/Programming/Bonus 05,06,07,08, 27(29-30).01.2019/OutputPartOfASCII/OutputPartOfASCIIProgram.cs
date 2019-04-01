using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputPartOfASCII
{
    class OutputPartOfASCIIProgram
    {
        static void Main(string[] args)
        {
            char smallest = (char)byte.Parse(Console.ReadLine());
            char biggest = (char)byte.Parse(Console.ReadLine());
            string characters = null;

            for (; smallest <= biggest; smallest++)
            {
                characters += smallest + " ";
            }

            Console.WriteLine(characters);
        }
    }
}
