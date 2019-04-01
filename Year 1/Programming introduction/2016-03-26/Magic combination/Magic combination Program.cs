using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int s1 = 1; s1 <= 9; s1++)
            {
                for (int s2 = 1; s2 <= 9; s2++)
                {
                    for (int s3 = 1; s3 <= 9; s3++)
                    {
                        for (int s4 = 1; s4 <= 9; s4++)
                        {
                            for (int s5 = 1; s5 <= 9; s5++)
                            {
                                for (int s6 = 1; s6 <= 9; s6++)
                                {
                                    if (s1 * s2 * s3 * s4 * s5 * s6 == n) Console.Write($"{s1}{s2}{s3}{s4}{s5}{s6} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
