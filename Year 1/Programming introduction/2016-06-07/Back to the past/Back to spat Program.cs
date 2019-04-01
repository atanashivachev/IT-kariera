using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_to_the_past
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int until = int.Parse(Console.ReadLine());
            double spendings = 0;
            int age = 18;

            for (int i = 0; i <= until - 1800; i++)
            {
                if (i % 2 == 0) spendings += 12000;
                else spendings += 12000 + 50 * age;

                age++;
            }

            if (money - spendings >= 0) Console.WriteLine($"Yes! He will live a carefree life and will have {money - spendings:F2} dollars left.");
            else Console.WriteLine($"He will need {spendings - money:F2} dollars to survive.");
        }
    }
}
