using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers___power_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (double i = 1; i <= Math.Pow(2, n); i *= 2) Console.WriteLine(i);
        }
    }
}
