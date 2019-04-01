using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arriveH = int.Parse(Console.ReadLine());
            int arriveM = int.Parse(Console.ReadLine());

            int examMin = (examH * 60) + examM;
            int arriveMin = (arriveH * 60) + arriveM;

            string when = null;
            string when1 = null;
            double time = 0;

            if (arriveMin < (examMin - 30))
            {
                when = "Early";
                when1 = "before";
                time = examMin - arriveMin;
            }
            else if (arriveMin < examMin)
            {
                when = "On time";
                when1 = "before";
                time = examMin - arriveMin;
            }
            else if (arriveMin == examMin)
            {
                when = "On time";
            }
            else
            {
                when = "Late";
                when1 = "after";
                time = arriveMin - examMin;
            }

            if (arriveMin == examMin)
            {
                Console.WriteLine(when);
            }
            else if (time < 60)
            {               
                Console.WriteLine($"{when}\r\n{time} minutes {when1} the start");
            }
            else
            {
                double timeH = Math.Floor(time / 60);
                double timeM = time % 60;

                if (timeM < 10) Console.WriteLine($"{when}\r\n{timeH}:0{timeM} hours {when1} the start");
                else Console.WriteLine($"{when}\r\n{timeH}:{timeM} hours {when1} the start");
            }
        }
    }
}
