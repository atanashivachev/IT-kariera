using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderCommands
{
    class StringBuilderProgram
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());

            string[] command = Console.ReadLine().Split(' ').ToArray();

            switch (command[0])
            {
                case "Append": text.Append(command[1]); break;
                case "Remove": text.Remove(int.Parse(command[1]), int.Parse(command[2])); break;
                case "Insert": text.Insert(int.Parse(command[1]), command[2]); break;
                case "Replace": text.Replace(command[1], command[2]); break;
            }

            Console.WriteLine(text);
        }
    }
}
