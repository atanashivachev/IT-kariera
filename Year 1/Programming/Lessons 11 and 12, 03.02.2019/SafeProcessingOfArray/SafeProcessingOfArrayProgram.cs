using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeProcessingOfArray
{
    class SafeProcessingOfArrayProgram
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            for (;;)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "END") break;
                else if (command[0] == "Reverse") Array.Reverse(input);
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    if (index < input.Length - 1 && index >= 0) input[int.Parse(command[1])] = command[2];
                    else Console.WriteLine("Invalid input!");
                }
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
                else Console.WriteLine("Invalid command!");
            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
