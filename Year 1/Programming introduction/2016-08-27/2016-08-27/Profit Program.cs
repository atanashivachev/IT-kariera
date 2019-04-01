using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            double workMonth = double.Parse(Console.ReadLine());
            double moneyDay = double.Parse(Console.ReadLine());
            double course = double.Parse(Console.ReadLine());

            double moneyMonth = moneyDay * workMonth;
            double moneyYear = moneyMonth * 12 + moneyMonth * 2.5;
            double usableMoneyYearLev = (moneyYear - moneyYear * 0.25) * course;
            Console.WriteLine($"{usableMoneyYearLev / 365:F2}");
        }
    }
}
