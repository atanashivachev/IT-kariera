using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = n - 1;
            int b = 5 * n - 2 * n;
            bool mid = false;

            Console.WriteLine(new string('.', n) + new string('*', 5 * n - 2 * n) + new string('.', n));
            for (int i = 0; i < 3 * n && b > 0; i++)
            {
                if (a == 1 && mid == false) { Console.WriteLine(new string('*', 5 * n)); mid = true; }
                else if (mid == false)
                {
                    
                    a--;
                    b += 2;
                    Console.WriteLine(new string('.', a) + "*" + new string('.', b) + "*" + new string('.', a));
                }
                else if (mid == true)
                {
                    Console.WriteLine(new string('.', a) + "*" + new string('.', b) + "*" + new string('.', a));
                    a++;
                    b -= 2;
                }

            }

            Console.WriteLine(new string('.', a) + "*" + new string('*', b) + "*" + new string('.', a));
        }
    }
}
