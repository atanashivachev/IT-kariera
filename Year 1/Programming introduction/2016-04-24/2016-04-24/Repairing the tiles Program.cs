using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repairing_the_tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            double tileW = double.Parse(Console.ReadLine());
            double tileL = double.Parse(Console.ReadLine());
            int benchW = int.Parse(Console.ReadLine());
            int benchL = int.Parse(Console.ReadLine());
                       
            int bench = benchW * benchL;
            int size = (side * side) - bench;
            double tile = tileW * tileL;

            Console.WriteLine(size / tile);
            Console.WriteLine(size / tile * 0.2);
        }
    }
}
