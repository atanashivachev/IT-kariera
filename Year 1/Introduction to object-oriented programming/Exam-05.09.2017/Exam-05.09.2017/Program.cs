using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_05._09._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            RaceTower.SetTrackInfo(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            while (RaceTower.CurrentLap < RaceTower.LapsNumber)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();

                try
                {
                    switch (command[0])
                    {
                        case "Box": RaceTower.DriverBoxes(command); break;
                        case "ChangeWeather": RaceTower.ChangeWeather(command); break;
                        case "CompleteLaps": RaceTower.CompleteLaps(command); break;
                        case "RegisterDriver": RaceTower.RegisterDriver(command); break;
                        case "Leaderboard": RaceTower.Leaderboard(); break;
                    }
                }
                catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            }

            RaceTower.Winner();
        }
    }
}
