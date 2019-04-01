using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeValueOfAAndB
{
    class ChangeValueOfAAndBProgram
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());

            long temporary = a;
            a = b;
            b = temporary;

            Console.WriteLine($"Before:\r\na = {b}\r\nb = {a}\r\nAfter:\r\na = {a}\r\nb = {b}");
        }
    }
}
