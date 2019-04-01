using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_money
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string fromCurrency = Console.ReadLine();
            string toCurrency = Console.ReadLine();

            if (fromCurrency == "BGN")
            {
                if (toCurrency == "USD")
                {
                    Console.WriteLine(Math.Round(money / 1.79549, 2) + " USD");
                }
                if (toCurrency == "EUR")
                {
                    Console.WriteLine(Math.Round(money / 1.95583, 2) + " EUR");
                }
                if (toCurrency == "GBP")
                {
                    Console.WriteLine(Math.Round(money / 2.53405, 2) + " GBP");
                }
            }
            if (fromCurrency == "USD")
            {
                if (toCurrency == "BGN")
                {
                    Console.WriteLine(Math.Round(money * 1.79549, 2) + " BGN");
                }
                if (toCurrency == "EUR")
                {
                    Console.WriteLine(Math.Round(money / (1.95583 / 1.79549) , 2) + " EUR");
                }
                if (toCurrency == "GBP")
                {
                    Console.WriteLine(Math.Round(money / (2.53405 / 1.79549), 2) + " GBP");
                }
            }
            if (fromCurrency == "EUR")
            {
                if (toCurrency == "BGN")
                {
                    Console.WriteLine(Math.Round(money * 1.95583, 2) + " BGN");
                }
                if (toCurrency == "USD")
                {
                    Console.WriteLine(Math.Round(money / (1.79549 / 1.95583), 2) + " EUR");
                }
                if (toCurrency == "GBP")
                {
                    Console.WriteLine(Math.Round(money / (2.53405 / 1.95583), 2) + " GBP");
                }
            }
            if (fromCurrency == "GBP")
            {
                if (toCurrency == "BGN")
                {
                    Console.WriteLine(Math.Round(money * 2.53405, 2) + " BGN");
                }
                if (toCurrency == "USD")
                {
                    Console.WriteLine(Math.Round(money / (1.79549 / 2.53405), 2) + " EUR");
                }
                if (toCurrency == "EUR")
                {
                    Console.WriteLine(Math.Round(money / (1.95583 / 2.53405), 2) + " GBP");
                }
            }
        }
    }
}
