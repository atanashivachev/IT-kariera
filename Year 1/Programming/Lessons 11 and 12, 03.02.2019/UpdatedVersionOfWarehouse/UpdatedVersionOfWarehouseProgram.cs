using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedVersionOfWarehouse
{
    class UpdatedVersionOfWarehouseProgram
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(' ');
            long[] amount = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            double[] prices = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (; ; )
            {
                string[] request = Console.ReadLine().Split(' ');

                if (request[0] == "done") break;
                else
                {
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (items[i] == request[0])
                        {
                            if (i >= amount.Length || long.Parse(request[1]) > amount[i])
                            {
                                Console.WriteLine($"We do not have enough {items[i]}");      
                            }
                            else
                            {
                                Console.WriteLine($"{items[i]} x {request[1]} costs {prices[i] * double.Parse(request[1]):F2}");
                                amount[i] -= long.Parse(request[1]);
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}
