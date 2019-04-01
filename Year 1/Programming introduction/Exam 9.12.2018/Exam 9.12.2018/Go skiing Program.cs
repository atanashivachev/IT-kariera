using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoSkiing
{
    class Program
    {
        static void Main(string[] args)
        {
            int skiers = int.Parse(Console.ReadLine());
            int jackets = int.Parse(Console.ReadLine());
            int helmets = int.Parse(Console.ReadLine());
            double shoes = int.Parse(Console.ReadLine());

            jackets *= 120;
            helmets *= 75;
            shoes *= 299.90;

            double totalPrice = (jackets + helmets + shoes) * skiers;
            double totalPriceDDZ = totalPrice + (totalPrice * 0.2);

            Console.WriteLine($"{totalPriceDDZ:F2}");

            // 100/100 tochki na tazi zadacha
        }
    }
}
