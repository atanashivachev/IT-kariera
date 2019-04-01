using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class WarehouseProgram
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(' ');
            long[] amount = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            double[] prices = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (; ; )
            {
                string item = Console.ReadLine();

                if (item == "done") break;
                else
                {
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (items[i] == item) Console.WriteLine($"{items[i]} costs: {prices[i]}; Available quantity: {amount[i]}");
                    }
                }
            }
        }
    }
}
