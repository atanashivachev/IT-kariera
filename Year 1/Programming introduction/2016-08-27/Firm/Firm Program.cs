using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededHours = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double totalWorkHours = Math.Floor(((days - days * 0.1) * 8) + (workers * days * 2));

            if (totalWorkHours >= neededHours) Console.WriteLine($"Yes!{totalWorkHours - neededHours} hours left.");
            else Console.WriteLine($"Not enough time!{neededHours - totalWorkHours} hours needed.");
        }
    }
}
