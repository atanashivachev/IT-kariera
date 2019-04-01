using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class BuilderProgram
    {
        static void Main(string[] args)
        {
            uint price1 = uint.Parse(Console.ReadLine());
            uint price2 = uint.Parse(Console.ReadLine());
            byte priceByte = 0;

            if (price1 < 128) { priceByte = Convert.ToByte(price1); price1 = 0; }
            else { priceByte = Convert.ToByte(price2); price2 = 0; }

            long sum = 4 * priceByte + 10 * price1 + 10 * price2;
            Console.WriteLine(sum);
        }
    }
}
