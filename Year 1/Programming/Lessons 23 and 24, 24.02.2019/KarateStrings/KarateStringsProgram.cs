using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateStrings
{
    class KarateStringsProgram
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());

            for (int i = input.ToString().IndexOf(">"), left = 0; i < input.Length; i++)
            {
                if (input[i].CompareTo('>') == 0)
                {    
                    int power = int.Parse(input[i + 1] + "");
                    power += left;

                    int posOfArrow = input.ToString().IndexOf(">", i + 1);
                    if (posOfArrow != -1 && posOfArrow - i - 1 < power)
                    {
                        left += power - (input.ToString().IndexOf(">", i + 1) - i - 1);
                        power = input.ToString().IndexOf(">", i + 1) - i - 1;
                    }

                    input.Remove(i + 1, power);
                }
            }

            Console.WriteLine(input);
        }
    }
}
