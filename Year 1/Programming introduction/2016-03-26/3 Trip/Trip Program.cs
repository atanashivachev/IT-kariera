using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = null;
            string stayin = null;
            double budgetPer = 0;

            if (budget <= 100)
            {
                place = "Bulgaria";
                switch (season)
                {
                    case "summer": budgetPer = budget * 0.3; stayin = "Camp"; break;
                    case "winter": budgetPer = budget * 0.7; stayin = "Hotel"; break;
                }
            }
            else if (budget > 1000)
            {
                place = "Europe";
                stayin = "Hotel";
                budgetPer = budget * 0.9;
            }
            else
            {
                place = "Balkans";
                switch (season)
                {
                    case "summer": budgetPer = budget * 0.4; stayin = "Camp"; break;
                    case "winter": budgetPer = budget * 0.8; stayin = "Hotel"; break;
                }
            }

            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{stayin} - {budgetPer:F2}");
        }
    }
}
