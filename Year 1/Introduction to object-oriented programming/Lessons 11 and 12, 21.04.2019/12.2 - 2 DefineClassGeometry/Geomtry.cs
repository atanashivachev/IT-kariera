using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2___2_DefineClassGeometry
{
    static class Geomtry
    {
        public static double SquarePerimeter(double side)
        {
            return side * 4;
        }

        public static double SquareArea(double side)
        {
            return side * side;
        }

        public static double RectanglePerimeter(double a, double b)
        {
            return 2 * (a + b);
        }

        public static double RectangleArea(double a, double b)
        {
            return a * b;
        }

        public static double CircleArea(double r)
        {
            return Math.PI * r * r;
        }
    }
}
