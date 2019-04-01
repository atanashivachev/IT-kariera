using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceAndTimeToSpeeds
{
    class DistanceAndTimeToSpeedsProgram
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            uint hours = uint.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            uint timeInSeconds = Convert.ToUInt32(seconds + (minutes * 60) + (hours * 3600));
            float metersPerSecond = distance / timeInSeconds;
            float kilometersPerHour = metersPerSecond / 1000 * 3600;
            float milesPerHour = metersPerSecond / 1609 * 3600;
            Console.WriteLine($"{metersPerSecond}\r\n{kilometersPerHour}\r\n{milesPerHour}");
        }
    }
}
