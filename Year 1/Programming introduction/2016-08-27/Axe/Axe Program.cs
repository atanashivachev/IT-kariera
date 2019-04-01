using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = -1;
            int h = n * 3;
            int b = n * 5 - h - 1;           
            bool mid = false;

            for (int i = 0; i <= n; i++)
            {
                if (i == n && mid == false)
                {
                    mid = true;
                    i = (i / 2) - 1;
                    for (int j = 0; j < n / 2; j++)
                    {
                        Console.WriteLine(new string('*', h) + "*" + new string('-', a) + "*" + new string('-', b));
                    }
                }
                else if (mid == false)
                {
                    a++;
                    b--;
                    Console.WriteLine(new string('-', h) + "*" + new string('-', a) + "*" + new string('-', b));
                }
                else if (mid == true)
                {
                    if (i == n - 1) { Console.WriteLine(new string('-', h) + new string('*', a + 2) + new string('-', b)); break; }
                    else
                    {
                        Console.WriteLine(new string('-', h) + "*" + new string('-', a) + "*" + new string('-', b));
                        a += 2;
                        b--;
                        h--;
                    }
                }
            }
        }
    }
}
