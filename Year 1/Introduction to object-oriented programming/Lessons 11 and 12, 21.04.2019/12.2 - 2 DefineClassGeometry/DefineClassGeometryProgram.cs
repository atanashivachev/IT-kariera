using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2___2_DefineClassGeometry
{
    class DefineClassGeometryProgram
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] calc = Console.ReadLine().Split(' ').ToArray();

                bool wrong = false;
                double val = 0;

                if (calc[0] == "END") break;

                if (calc[0] == "Circle") val = Geomtry.CircleArea(double.Parse(calc[1]));
                else if (calc[0] == "Square")
                {
                    if (calc[1] == "Perimeter") val = Geomtry.SquarePerimeter(double.Parse(calc[2]));
                    else if (calc[1] == "Area") val = Geomtry.SquareArea(double.Parse(calc[2]));
                    else wrong = true;
                }
                else if (calc[0] == "Rectangle")
                {
                    if (calc[1] == "Perimeter") val = Geomtry.RectanglePerimeter(double.Parse(calc[2]), double.Parse(calc[3]));
                    else if (calc[1] == "Area") val = Geomtry.RectangleArea(double.Parse(calc[2]), double.Parse(calc[3]));
                    else wrong = true;
                }
                else wrong = true;

                if (wrong) Console.WriteLine("Wrong argumnets");
                else Console.WriteLine($"   = {val}");
            }
        }
    }
}
