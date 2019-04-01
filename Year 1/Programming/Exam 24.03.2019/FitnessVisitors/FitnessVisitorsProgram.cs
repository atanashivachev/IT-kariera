using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessVisitors
{
    class FitnessVisitorsProgram
    {
        static void Main(string[] args)
        {
            //solved in 15 min, 100/100 points

            List<string> visitors = Console.ReadLine().Split(' ', ',').Where(x => x != "").ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("END")) break;
                else
                {
                    switch (command)
                    {
                        case "Remove last visitor": visitors.RemoveAt(visitors.Count() - 1); break;
                        case "Remove first visitor": visitors.RemoveAt(0); break;
                        case "Remove visitor on position": visitors.RemoveAt(int.Parse(Console.ReadLine())); break;
                        case "Add visitor": visitors.Add(Console.ReadLine()); break;
                        case "Add visitor on position":
                        string name = Console.ReadLine();
                        visitors.Insert(int.Parse(Console.ReadLine()), name); break;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", visitors));
        }
    }
}
