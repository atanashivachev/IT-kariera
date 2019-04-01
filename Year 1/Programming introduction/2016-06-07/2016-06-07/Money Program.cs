using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoin = int.Parse(Console.ReadLine());
            double chineseUan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double money = bitcoin * 1168 / 1.95 + chineseUan * 0.15 * 1.76 / 1.95;
            money -= money * commision / 100;
            Console.WriteLine(money);
        }
    }
}
