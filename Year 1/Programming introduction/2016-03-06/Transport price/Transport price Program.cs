using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_price
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine();
            double price = 0;

            if (n >= 100) price = n * 0.06;
            else if (n >= 20) price = n * 0.09;
            else
            {
                price += 0.7;
                if (dayNight == "day") price += n * 0.79;
                else price += n * 0.9;
            }

            Console.WriteLine(price);
        }
    }
}
