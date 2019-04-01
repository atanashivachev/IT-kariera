using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOfListWithConsole
{
    class InputOfListWithConsoleProgram
    {
        static void Main(string[] args)
        {
            List<Int32> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"nums[{i}] = {input[i]}");
            }
        }
    }
}
