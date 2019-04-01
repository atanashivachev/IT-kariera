using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerKegVolume
{
    class BeerKegVolumeProgram
    {
        static void Main(string[] args)
        {
            byte rows = byte.Parse(Console.ReadLine());
            string biggestKeg = null;
            double v = 0;

            for (byte i = 0; i < rows; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                uint height = uint.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;
                if (volume > v) { v = volume; biggestKeg = model; }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
