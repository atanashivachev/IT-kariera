using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5___Unique_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int i = b;

            for (int j = a; j < 122; j++)
            {
                char firstLetter = (char)(j);

                for (; i <= 122; i++)
                {
                    for (; i > j;)
                    {
                        if (i == 123) break;

                        int m = 8;

                        char secondLetter = (char)(i);

                        for (int n = 1; n < 9; n++)
                        {
                            if (n + m == 9)
                            {
                                Console.Write($"{firstLetter}{secondLetter}{n}{m} ");
                                m--;
                            }
                        }
                      
                    }
                    //i++;
                }
                i = 'a';
            }
        }
    }
}