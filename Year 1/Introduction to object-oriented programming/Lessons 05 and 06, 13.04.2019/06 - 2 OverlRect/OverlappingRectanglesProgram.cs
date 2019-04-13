using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___2_OverlRect
{
    class OverlappingRectanglesProgram
    {
        static void Main(string[] args)
        {
            Dictionary<string, Rectangle> rects = new Dictionary<string, Rectangle>();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for(int i = 0; i < numbers[0]; i++)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();
                int[] nInfo = info.Skip(1).Select(int.Parse).ToArray();

                rects.Add(info[0], new Rectangle(info[0], nInfo[1], nInfo[0], nInfo[2], nInfo[3]));
            }

            for(int i = 0; i < numbers[1]; i++)
            {
                string[] ids = Console.ReadLine().Split(' ').ToArray();
                Console.WriteLine(rects[ids[0]].OverlapsWith(rects[ids[1]]));
            }
        }
    }
}
