using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double r = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double seats = r * c;
            double price = 0;

            switch (type)
            {
                case "Premiere": price = seats * 12; break;
                case "Normal": price = seats * 7.5; break;
                case "Discount": price = seats * 5; break;
            }
            Console.WriteLine($"{price:F2} leva");
        }
    }
}
