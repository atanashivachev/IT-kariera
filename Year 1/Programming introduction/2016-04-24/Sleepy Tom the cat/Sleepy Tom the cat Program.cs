using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom_the_cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int rest = int.Parse(Console.ReadLine());

            double workdays = 365 - rest;
            double playtime = (workdays * 63) + (rest * 127);

            if (playtime < 30000)
            {
                double left = 30000 - playtime;
                double h = Math.Floor(left / 60);
                double m = left % 60;
                Console.WriteLine($"Tom sleeps well\r\n{h} hours and {m} minutes less for play");
            }
            else
            {
                double left = playtime - 30000;
                double h = Math.Floor(left / 60);
                double m = left % 60;
                Console.WriteLine($"Tom will run away\r\n{h} hours and {m} minutes more for play");
            }
        }
    }
}
