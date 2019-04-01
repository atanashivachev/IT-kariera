using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wine
{
    class Program
    {
        static void Main(string[] args)
        {
            double overallarea = double.Parse(Console.ReadLine());
            double totalGrapes = double.Parse(Console.ReadLine());
            double needed = double.Parse(Console.ReadLine());
            double work = double.Parse(Console.ReadLine());

            double area = overallarea * 0.4;
            double wine = (area * totalGrapes) / 2.5;

            if (wine >= needed)
            {

                double x = Math.Round(wine - needed, 0);
                wine = Math.Floor(wine);
                double y = Math.Ceiling(x / work);
                Console.WriteLine($"Good harvest this year! Total wine: {wine} liters.\r\n{x} liters left -> {y} liters per person.");
            }
            else
            {
                double x = Math.Floor(needed - wine);
                Console.WriteLine($"It will be a tough winter! More {x} liters wine needed.");
            }
        }
    }
}
