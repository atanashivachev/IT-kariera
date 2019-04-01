using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_15_to_time
{
    class Program
    {
        static void Main(string[] args)
        {
            int hh = int.Parse(Console.ReadLine());
            int mm = int.Parse(Console.ReadLine());
            mm = mm + 15;

            if (mm > 59)
            {
                hh = hh + 1;
                mm = mm - 60;
                if (hh > 23)
                {
                    hh = hh - 24;
                    if (mm < 10)
                    {
                        Console.WriteLine($"{hh}:0{mm}");
                    }
                    else
                    {
                        Console.WriteLine($"{hh}:{mm}");
                    }
                }
                else
                {
                    if (mm < 10)
                    {
                        Console.WriteLine($"{hh}:0{mm}");
                    }
                    else
                    {
                        Console.WriteLine($"{hh}:{mm}");
                    }
                }
            }
            else
            {
                if (hh > 23)
                {
                    hh = hh - 24;
                    if (mm < 10)
                    {
                        Console.WriteLine($"{hh}:0{mm}");
                    }
                    else
                    {
                        Console.WriteLine($"{hh}:{mm}");
                    }
                }
                else
                {
                    if (mm < 10)
                    {
                        Console.WriteLine($"{hh}:0{mm}");
                    }
                    else
                    {
                        Console.WriteLine($"{hh}:{mm}");
                    }
                }              
            }
        }
    }
}
