using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortHours
{
    class SortHoursProgram
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
