using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingList
{
    class ChangingListProgram
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (; ; )
            {
                String[] command = Console.ReadLine().Split(' ').ToArray();

                if (command[0] == "Odd")
                {
                    Console.WriteLine(string.Join(" ", input.Where(x => x % 2 != 0)));
                    break;
                }
                else if (command[0] == "Even")
                {
                    Console.WriteLine(string.Join(" ", input.Where(x => x % 2 == 0)));
                    break;
                }
                else if (command[0] == "Delete")
                {
                    input.RemoveAll(x => x == int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
            }
        }
    }
}
