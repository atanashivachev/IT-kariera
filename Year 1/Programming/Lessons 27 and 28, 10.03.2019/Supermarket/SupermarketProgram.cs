using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class SupermarketProgram
    {
        static void Main(string[] args)
        {
            var order = new Dictionary<string, double[]>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "stocked") break;

                if (!order.ContainsKey(input[0]))
                {
                    double[] priceAndQuantity = { double.Parse(input[1]), double.Parse(input[2]) };
                    order.Add(input[0], priceAndQuantity);
                }
                else
                {
                    order[input[0]][0] = double.Parse(input[1]);
                    order[input[0]][1] += double.Parse(input[2]);
                }
            }

            double total = 0;
            foreach (var pair in order)
            {
                double price = pair.Value[0] * pair.Value[1];
                total += price;
                Console.WriteLine($"{pair.Key}: ${pair.Value[0]:F2} * {pair.Value[1]} = ${price:F2}");
            }

            PrintEnd(total);
        }

        static void PrintEnd(double total)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand total: ${total:F2}");
        }
    }
}
