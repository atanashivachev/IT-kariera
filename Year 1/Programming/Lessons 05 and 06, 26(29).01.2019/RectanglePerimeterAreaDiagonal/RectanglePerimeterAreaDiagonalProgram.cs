using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePerimeterAreaDiagonal
{
    class RectanglePerimeterAreaDiagonalProgram
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            decimal perimeter = Convert.ToDecimal(2 * (a + b));
            decimal area = Convert.ToDecimal(a * b);
            decimal diagonal = Convert.ToDecimal(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b,2)));

            Console.WriteLine($"{perimeter}\r\n{area}\r\n{diagonal}");
        }
    }
}
