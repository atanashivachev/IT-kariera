using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            if (a1 < 97) a1 = 97;
            char a = intToChar(a1);
            char b = intToChar(b1);

            for (; a < 'z';)
            {
                for (; b > a; b++)
                {
                    for (int k = 1; k < 10; k++)
                    {
                        for (int l = 1; l < 10; l++)
                        {
                            if (k + l == 9)
                            {
                                if (b > 'z') break;
                                Console.Write($"{a}{b}{k}{l} ");
                            }
                        }
                    }
                    if (b == 'z') a++;
                }
                b++;
            }
        }
        static char intToChar(int a)
        {
            char b = '`';
            for (char s = '`'; s < a; s++)
            {
                b++;
            }
            return b;
        }
    }
}
