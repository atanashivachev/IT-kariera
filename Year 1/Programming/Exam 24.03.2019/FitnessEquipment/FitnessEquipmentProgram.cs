using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessEquipment
{
    class FitnessEquipmentProgram
    {
        static void Main(string[] args)
        {
            //solved in 10 min, 100/100 points
            byte equpment = byte.Parse(Console.ReadLine());

            double sum = 0.0;
            for (byte i = 0; i < equpment; i++)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "treadmill": sum += 5899; break;
                    case "cross trainer": sum += 1699; break;
                    case "exercise bike": sum += 1789; break;
                    case "dumbbells": sum += 579; break;
                }
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
