using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_from_100_to_200
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string res = null;

            if (a < 100)
            {
                res = "Smaller than 100";
            }
            else if (a > 100 && a < 200)
            {
                res = "Between 100 and 200";
            }
            else if (a > 200)
            {
                res = "Bigger than 200";
            }

            Console.WriteLine(res);
        }
    }
}
