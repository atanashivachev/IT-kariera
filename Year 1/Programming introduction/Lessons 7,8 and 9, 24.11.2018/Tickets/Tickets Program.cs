using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double money = 0;
            double tickets = 0;
            double total = 0;

            if (people >= 50)
            {
                money = budget * 0.25;
            }
            else if (people >= 25)
            {
                money = budget * 0.4;
            }
            else if (people >= 10)
            {
                money = budget * 0.5;
            }
            else if (people >= 5)
            {
                money = budget * 0.6;
            }
            else
            {
                money = budget * 0.75;
            }

            switch (category)
            {
                case "VIP": tickets = people * 499.99; break;
                case "Normal": tickets = people * 249.99; break;
            }

            total = Math.Round(budget - (money + tickets), 2);

            if (total >= 0) Console.WriteLine($"Yes! You have {total} leva left.");
            else Console.WriteLine($"Not enough money! You need {Math.Abs(total)} leva.");
        }
    }
}
