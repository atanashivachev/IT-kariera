using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._11._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double a = double.Parse(Console.ReadLine());
                if (a >= 100 && a <= 200 || a == 0) { }
                else Console.WriteLine("Invalid");
            }
        }
    }
}
