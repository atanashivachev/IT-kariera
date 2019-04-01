using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
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
                a = 2;
                b = (n / 2) - 1;
                for (int i = 0; i < (n + 1)/ 2; i++)
                {
                    Console.WriteLine(new string('_', b) + new string('*', a) + new string('_', b));
                    a += 2;
                    b -= 1;
                }

                for (int i2 = 0; i2 < n / 2; i2++)
                {
                    Console.WriteLine("|" + new string('*', n - 2) + "|");
                }
            }
            else
            {
                a = 1;
                b = (n - 1) / 2;
                for (int i = 0; i < (n + 1) / 2; i++)
                {
                    Console.WriteLine(new string('_', b) + new string('*', a) + new string('_', b));
                    a += 2;
                    b -= 1;
                }

                for (int i2 = 0; i2 < (n - 1) / 2; i2++)
                {
                    Console.WriteLine("|" + new string('*', n - 2) + "|");
                }
            }
        }
    }
}
