using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sun_glasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = n - 2;

            Console.WriteLine(new string('*', n * 2) + new string (' ', n) + new string('*', n * 2));
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*" + new string('/', a + n) + "*");
                if (n % 2 != 0 && i == (n/2) - 1) Console.WriteLine(new string('|', n) + "*" + new string('/', a + n) + "*");
                else if (n % 2 == 0 && i == (n / 2) - 2) Console.WriteLine(new string('|', n) + "*" + new string('/', a + n) + "*");
                else Console.WriteLine(new string(' ', n) + "*" + new string('/', a + n) + "*");
        }
            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));
        }
    }
}
