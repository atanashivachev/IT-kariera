using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_info
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            string info = null;

            if (speed <= 10)
            {
                info = "slow";
            }
            else if (speed <= 50)
            {
                info = "average";
            }
            else if (speed <= 150)
            {
                info = "fast";
            }
            else if (speed <= 1000)
            {
                info = "ultra fast";
            }
            else
            {
                info = "extremly fast";
            }
            Console.WriteLine(info);
        }
    }
}
