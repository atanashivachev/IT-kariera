using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_time_for_the_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arriveH = int.Parse(Console.ReadLine());
            int arriveM = int.Parse(Console.ReadLine());

            int examTime = (examH * 60) + examM;
            int arriveTime = (arriveH * 60) + arriveM;

            string status = null;
            string when = null;
            int diff = 0;

            if (arriveTime < examTime - 30)
            {
                status = "Early";
                when = "before";
                diff = examTime - arriveTime;
            }
            else if (arriveTime <= examTime)
            {
                status = "On time";
                diff = examTime - arriveTime;
            }
            else
            {
                status = "Late";
                diff = arriveTime - examTime;
                when = "after";
            }

            if (status == "On time")
            {
                Console.WriteLine(status);
                if (diff == 0) ;
                else Console.WriteLine($"{diff} minutes before the start");
            }
            else
            {
                int H = diff / 60;
                int M = diff % 60;

                Console.WriteLine(status);

                if (H >= 1)
                {
                    if (M <= 9)Console.WriteLine($"{H}:0{M} hours {when} the start");
                    else Console.WriteLine($"{H}:{M} hours {when} the start");
                }
                else Console.WriteLine($"{M} minutes {when} the start");
            }
        }
    }
}
