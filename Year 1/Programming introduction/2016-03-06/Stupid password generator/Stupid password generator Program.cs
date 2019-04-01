using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_password_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int h = 1;h < n; h++)
                {
                    for (int j = 0; j < l;j++)
                    {
                        for (int k = 0; k < l; k++)
                        {
                            for (int g = 1; g <= n; g++)
                            {
                                if (g > i && g > h)
                                {
                                    char firstLetter = (char)(j + 97);
                                    char secondLetter = (char)(k + 97);
                                    Console.Write("" + i + h + firstLetter + secondLetter + g + " ");
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }
}
