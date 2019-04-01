using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation_price
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double price = 0;

            if (n >= 100)
            {
                price = n * 0.06;
            }
            else if (n >= 25)
            {
                price = n * 0.09;
            }
            else
            {
                switch (time)
                {
                    case "day": price = n * 0.79 + 0.7; break;
                    case "night": price = n * 0.9 + 0.7; break; 
                }
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
