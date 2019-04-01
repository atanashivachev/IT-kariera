using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInformation
{
    class TouristInformationProgram
    {
        static void Main(string[] args)
        {
            string imperial = Console.ReadLine();
            float amountImperial = float.Parse(Console.ReadLine());
            string metric = null;
            double amountMetric = 0;

            switch (imperial)
            {
                case "miles": metric = "kilometers"; amountMetric = amountImperial * 1.6; break;
                case "inches": metric = "centimeters"; amountMetric = amountImperial * 2.54; break;
                case "feet": metric = "centimeters"; amountMetric = amountImperial * 30; break;
                case "yards": metric = "meters"; amountMetric = amountImperial * 0.91; break;
                case "gallons": metric = "liters"; amountMetric = amountImperial * 3.8; break;
            }

            Console.WriteLine($"{amountImperial} {imperial} = {amountMetric:F2} {metric}");
        }
    }
}
