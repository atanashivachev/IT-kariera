using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heist
{
    class HeistProgram
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int priceJewels = prices[0];
            int priceGold = prices[1];
            
            int earnings = 0;
            int expenses = 0;

            for (; ; )
            {
                List<string> robbery = Console.ReadLine().Split(' ').ToList();
                if (robbery[0] == "Jail") break;

                expenses += int.Parse(robbery[1]);

                for (int i = 0; i < robbery[0].Length; i++)
                {
                    if (robbery[0][i] == '%') earnings += priceJewels;
                    else if (robbery[0][i] == '$') earnings += priceGold;
                }
            }

            earnings -= expenses;

            if (earnings >= 0) Console.WriteLine($"Heists will continue. Total earnings: {earnings}.");
            else Console.WriteLine($"Have to find another job. Lost: {Math.Abs(earnings)}.");
        }
    }
}
