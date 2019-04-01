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
            int a = 0;
            int b = 0;

            if (n % 2 == 0)
            {              
                a = (n / 2) - 1;
                b = 0;
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine(new string('-', a) + "*" + new string('-', b) + "*" + new string('-', a));
                    a -= 1;
                    b += 2;
                }
                a += 1;
                b -= 2;
                for (int i = 1; i < n / 2; i++)
                {
                    a += 1;
                    b -= 2;
                    Console.WriteLine(new string('-', a) + "*" + new string('-', b) + "*" + new string('-', a));
                    
                }
            }
            else
            {
                a = (n - 1) / 2;
                b = 1;
                Console.WriteLine(new string('-', a) + "*" + new string('-', a));
                a -= 1;
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine(new string('-', a) + "*" + new string('-', b) + "*" + new string('-', a));
                    a -= 1;
                    b += 2;
                }
                a += 1;
                b -= 2;
                for (int i = 1; i < n / 2; i++)
                {
                    a += 1;
                    b -= 2;
                    Console.WriteLine(new string('-', a) + "*" + new string('-', b) + "*" + new string('-', a));
                }
                a += 1;
                Console.WriteLine(new string('-', a) + "*" + new string('-', a));
            }
        }
    }
}
