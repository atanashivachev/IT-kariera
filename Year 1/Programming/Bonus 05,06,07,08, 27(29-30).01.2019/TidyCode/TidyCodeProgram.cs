using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TidyCode
{
    class TidyCodeProgram
    {
        static void Main(string[] args)
        {
            /* code to tidy
            int ___Do___ = int.Parse(Console.ReadLine());
            for (int DAVIDIM = 0; DAVIDIM <= ___Do___; DAVIDIM++)
            {
                bool TowaLIE = true;
                for (int delio = 2; delio <= Math.Sqrt(DAVIDIM); delio++)
                {
                    if (DAVIDIM % delio == 0)
                    {
                        TowaLIE = false;
                        break;
                    }
                }
                Console.WriteLine($"{DAVIDIM} -> {TowaLIE}");
            }
            */

            int inputNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNum; i++)
            {
                bool prime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {prime}");
            }
        }
    }
}
