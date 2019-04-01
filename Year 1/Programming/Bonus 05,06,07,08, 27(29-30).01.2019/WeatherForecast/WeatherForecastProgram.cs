using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    class WeatherForecastProgram
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            long number = 0;
            bool integer = long.TryParse(inputNum, out number);
            string weather = null;

            if (integer)
            {
                if (number <= sbyte.MaxValue)
                {
                    weather = "Sunny";
                }
                else if (number <= int.MaxValue)
                {
                    weather = "Cloudy";
                }
                else
                {
                    weather = "Windy";
                }
            }
            else
            {
                weather = "Rainy";
            }

            Console.WriteLine(weather);
        }
    }
}
