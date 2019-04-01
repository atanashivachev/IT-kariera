using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaireRealNumbers
{
    class CompaireRealNumbersProgram
    {
        static void Main(string[] args)
        {
            double num1 = Math.Round(double.Parse(Console.ReadLine()), 6);
            double num2 = Math.Round(double.Parse(Console.ReadLine()), 6);

            if (num1 == num2) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
