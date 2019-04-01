using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{
    class AreaOfTriangleProgram
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(Area(width, height));
        }
        static double Area(double width, double height)
        {
            return width * height / 2;
        }
    }
}
