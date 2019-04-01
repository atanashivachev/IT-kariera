using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizeOfWholeNumber
{
    class SizeOfWholeNumberProgram
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long number = 0;
            if (long.TryParse(input, out number))
            {
                Console.WriteLine("Can fit in:");
                if (number < sbyte.MaxValue && number > sbyte.MinValue) Console.WriteLine("* sbyte");
                if (number < byte.MaxValue && number > byte.MinValue) Console.WriteLine("* byte");
                if (number < short.MaxValue && number > short.MinValue) Console.WriteLine("* short");
                if (number < ushort.MaxValue && number > ushort.MinValue) Console.WriteLine("* ushort");
                if (number < int.MaxValue && number > int.MinValue) Console.WriteLine("* int");
                if (number < uint.MaxValue && number > uint.MinValue) Console.WriteLine("* uint");
                if (number < long.MaxValue && number > long.MinValue) Console.WriteLine("* long");
            }
            else
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
