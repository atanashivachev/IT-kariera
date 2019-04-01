using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int ss1 = int.Parse(Console.ReadLine());
            int ss2 = int.Parse(Console.ReadLine());
            int ss3 = int.Parse(Console.ReadLine());

            int ss = ss1 + ss2 + ss3;
            int hh = 0;

            if (ss < 120 && ss > 60)
            {
                hh += 1;
                ss -= 60;
            }
            else if (ss > 120 && ss < 180)
            {
                hh += 2;
                ss -= 120;
            }
            else if (ss == 180)
            {
                hh += 3;
                ss -= 180;
            }
            else if (ss == 60)
            {
                hh += 1;
                ss -= 60;
            }

            if (ss < 10)
            {
                Console.WriteLine($"{hh}:0{ss}");
            }
            else
            {
                Console.WriteLine($"{hh}:{ss}");
            }
        }
    }
}
