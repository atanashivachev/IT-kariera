using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    class AnonymousThreatProgram
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                if (command[0] == "3:1") break;
                else if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0) startIndex = 0;
                    else if (startIndex >= input.Count) startIndex = input.Count() - 1;

                    if (endIndex < 0) startIndex = 0;
                    else if (endIndex >= input.Count) endIndex = input.Count() - 1;

                    for (int i = startIndex; i < endIndex; i++)
                    {
                        input[startIndex] = string.Concat(input[startIndex], input[startIndex + 1]);
                        input.RemoveAt(startIndex + 1);
                    }
                }
                else
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);

                    StringBuilder element = new StringBuilder(input[index]);
                    int elementLength = element.Length;
                    input.RemoveAt(index);

                    string[] substrings = new string[partitions];
                    for (int i = 0; i < substrings.Length; i++)
                    {
                        if (i == substrings.Length - 1) substrings[i] = element.ToString();
                        else
                        {
                            substrings[i] = element.ToString().Substring(0, elementLength / partitions);
                            element.Remove(0, elementLength / partitions);
                        }
                    }

                    input.InsertRange(index, substrings.ToList());
                }

            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
