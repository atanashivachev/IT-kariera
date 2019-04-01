using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top3Biggest
{
    class Top3BiggestProgram
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).OrderByDescending(x => x).ToList();

            for (int i = 0; i < input.Count && i < 3; i++)
            {
                Console.Write(input[0]);
                input.RemoveAt(0);
            }
        }
    }
}
