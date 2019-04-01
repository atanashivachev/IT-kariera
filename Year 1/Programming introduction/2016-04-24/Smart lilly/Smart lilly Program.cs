using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int p = 10;
            int savings = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) { savings += p - 1; p += 10; }
                else { savings += toyPrice; }
            }

            if (savings - washerPrice >= 0) Console.WriteLine($"Yes! {savings - washerPrice:F2}");
            else Console.WriteLine($"No! {washerPrice - savings:F2}");
        }
    }
}
