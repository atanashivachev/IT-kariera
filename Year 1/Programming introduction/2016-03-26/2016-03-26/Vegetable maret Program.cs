using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVeg = double.Parse(Console.ReadLine());
            double priceFrt = double.Parse(Console.ReadLine());
            double kilogramsVeg = double.Parse(Console.ReadLine());
            double kilogramsFrt = double.Parse(Console.ReadLine());

            double totalVeg = priceVeg * kilogramsVeg;
            double totalFrt = priceFrt * kilogramsFrt;

            Console.WriteLine((totalVeg + totalFrt) / 1.94);
        }
    }
}
