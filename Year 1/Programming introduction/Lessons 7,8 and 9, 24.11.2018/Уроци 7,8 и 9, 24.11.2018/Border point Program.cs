using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Border_points
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool RightSide = x == x2 && y <= y2 && y >= y1;
            bool LeftSide = x == x1 && y <= y2 && y >= y1;
            bool BottomSide = y == y2 && x <= x2 && x >= x1;
            bool TopSide = y == y1 && x <= x2 && x >= x1;

            if (RightSide || LeftSide || BottomSide || TopSide) Console.WriteLine("Border");
            else Console.WriteLine("Inside/Outside");
        }
    }
}
