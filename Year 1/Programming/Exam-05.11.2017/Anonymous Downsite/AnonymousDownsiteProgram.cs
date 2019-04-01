using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDownsite
{
    class AnonymousDownsiteProgram
    {
        static void Main(string[] args)
        {
            Byte affWebsites = Byte.Parse(Console.ReadLine());
            Byte securityKey = Byte.Parse(Console.ReadLine());

            decimal lost = 0;

            for (int i = 0; i < affWebsites; i++)
            {
                string[] siteInfo = Console.ReadLine().Split(' ').ToArray();
                Console.WriteLine(siteInfo[0]);

                lost += uint.Parse(siteInfo[1]) * decimal.Parse(siteInfo[2]);
            }

            Console.WriteLine($"Total loss: {lost:F20}");
            Console.WriteLine($"Security token: {BigInteger.Pow(securityKey, affWebsites)}");
        }
    }
}
