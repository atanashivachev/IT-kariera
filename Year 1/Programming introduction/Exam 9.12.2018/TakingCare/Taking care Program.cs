using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taking_care
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodTotal = int.Parse(Console.ReadLine());
            foodTotal = foodTotal * 1000;
            int days = int.Parse(Console.ReadLine());
            int foodPerDay = 0;

            for (int i = 0; i < days; i++)
            {
                int PerDay = int.Parse(Console.ReadLine());
                foodPerDay += PerDay;
            }

            if (foodTotal >= foodPerDay)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodTotal - foodPerDay} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodPerDay - foodTotal} grams more.");
            }

            // 100/100 na tazi zadacha
        }
    }
}
