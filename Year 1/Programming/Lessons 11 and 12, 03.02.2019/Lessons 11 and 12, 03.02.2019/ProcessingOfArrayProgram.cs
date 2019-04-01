using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_11_and_12__03._02._2019
{
    class ProcessingOfArrayProgram
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            byte amountOfCommands = byte.Parse(Console.ReadLine());

            for (byte i = 0; i < amountOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "Reverse") Array.Reverse(input);
                else if (command[0] == "Replace") input[int.Parse(command[1])] = command[2];
                else if (command[0] == "Distinct")
                {
                    for (int k = 0; k < input.Length; k++)
                    {
                        for (int l = 0; l < input.Length; l++)
                        {
                            if (input[k] == input[l] && k != l) Array.Clear(input, l, 1);
                        }
                    }
                    input = input.Where(x => x != null).ToArray();
                }
            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
