using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_15._07._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arguments = new List<string>();

            do
            {
                arguments = Console.ReadLine().Split(' ').ToList();

                try
                {
                    switch (arguments[0])
                    {
                        case "RegisterHarvester": DraftManager.RegisterHarvester(arguments); break;
                        case "RegisterProvider": DraftManager.RegisterProvider(arguments); break;
                        case "Day": DraftManager.Day(); break;
                        case "Mode": DraftManager.Mode(arguments); break;
                        case "Check": DraftManager.Check(arguments); break;
                        case "Shutdown": DraftManager.Shutdown(); break;
                    }
                }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            }
            while (arguments[0] != "Shutdown");
        }
    }
}
