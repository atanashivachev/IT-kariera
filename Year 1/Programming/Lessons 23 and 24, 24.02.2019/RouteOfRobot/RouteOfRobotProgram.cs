using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteOfRobot
{
    class RouteOfRobotProgram
    {
        static void Main(string[] args)
        {
            StringBuilder commands = new StringBuilder(Console.ReadLine());

            string direction = "x+";
            int x = 0;
            int y = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i].CompareTo('L') == 0 || commands[i].CompareTo('R') == 0) direction = Turn(commands[i], direction);
                else
                {
                    int goLength = int.Parse(commands.ToString().Substring(i, LengthFinder(i, commands)));
                    i += LengthFinder(i, commands) - 1;

                    switch (direction)
                    {
                        case "x+": x += goLength; break;
                        case "x-": x -= goLength; break;
                        case "y+": y += goLength; break;
                        case "y-": y -= goLength; break;
                    }
                }
            }

            Console.WriteLine($"Position: (x: {x}, y:{y}), Distance = {Math.Sqrt(x*x + y*y):F2}");
        }
    
        static string Turn(char rot, string dir)
        {
            if (rot == 'R')
            {
                switch (dir)
                {
                    case "x+": return "y-";
                    case "x-": return "y+";
                    case "y+": return "x+";
                    case "y-": return "x-";
                }
            }
            else
            {
                switch (dir)
                {
                    case "x+": return "y+";
                    case "x-": return "y-";
                    case "y+": return "x-";
                    case "y-": return "x+";
                }
            }
            //obligaotry, because not all paths return a value
            return "ERROR";
        }

        static int LengthFinder(int startPos, StringBuilder com)
        {
            for (int i = startPos; i < com.Length; i++)
            {
                if (com[i] != '1' && com[i] != '2' && com[i] != '3' &&
                    com[i] != '4' && com[i] != '5' && com[i] != '6' &&
                    com[i] != '7' && com[i] != '8' && com[i] != '9' &&
                    com[i] != '0') return i - startPos;
            }

            //if there are only digits until the end, we say the length is until the end of the string
            return com.Length - startPos;
        }
    }
}
