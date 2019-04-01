using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); //chislo bukva a
            int b = int.Parse(Console.ReadLine()); // chislo bukva b

            for (int i = a; i <= 122; i++)
            {
                for (int k = b; k <= 122; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            if (l + m == 9 && k > i)
                            {
                                Console.Write("" + (char)i + (char)k + l + m + " ");
                            }
                        }
                    }
                }
            }
        }
    }
}