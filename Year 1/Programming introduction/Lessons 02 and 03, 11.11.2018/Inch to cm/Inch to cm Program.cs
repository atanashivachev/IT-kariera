using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inch_to_cm
{
    class Program
    {
        static void Main(string[] args)
        {
            double Inch = double.Parse(Console.ReadLine());
            double Cm = Inch * 2.54;
            Console.WriteLine(Cm);
        }
    }
}
