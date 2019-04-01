using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulator
{
    class ListManipulatorProgram
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int containsIndex = 0;

            for (; ; )
            {
                List<string> commandList = Console.ReadLine().Split(' ').ToList();
                string command = commandList[0];

                //this if divides the commands into 2 types, ones with only a command word, and the others, with a word and numbers next to them
                if (command == "print" || command == "sumPairs")
                {
                    if (command == "print") break;
                    else
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            input[i] += input[i + 1];
                            input.RemoveAt(i + 1);
                        }
                    }
                }
                else
                {
                    int pointer = int.Parse(commandList[1]);
                    //the number, next to the command has different functionality that depends on the command, but generally it points to something

                    if (command == "add")
                    {
                        //here pointer acts as an index
                        input.Insert(pointer, int.Parse(commandList[2]));
                    }

                    else if (command == "addMany")
                    {
                        //here pointer acts as an index
                        input.InsertRange(pointer, commandList.GetRange(2, commandList.Count - 2).Select(int.Parse));
                    }

                    else if (command == "contains")
                    {
                        //here pointer acts as an element
                        if (input.Contains(pointer))
                        {
                            containsIndex = input[pointer];
                        }
                        else
                        {
                            containsIndex = -1;
                        }
                        Console.WriteLine(containsIndex);
                    }

                    else if (command == "remove")
                    {
                        //here pointer acts as an index
                        input.RemoveAt(pointer);
                    }

                    else if (command == "shift")
                    {
                        //here pointer shows with how many positions to shift the list

                        List<int> tempList = input.GetRange(0, pointer);
                        input.RemoveRange(0, pointer);
                        input.AddRange(tempList);
                    }
                }
            }
         
            Console.WriteLine("[" + string.Join(", ", input) + "]");
        }
    }
}
