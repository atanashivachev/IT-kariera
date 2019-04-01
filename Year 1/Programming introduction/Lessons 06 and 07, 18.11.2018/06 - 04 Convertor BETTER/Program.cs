using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___04_Convertor_BETTER
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string fromType = Console.ReadLine();
            string toType = Console.ReadLine();

            double outputVal = 0;
            double cal = 0;

            if (fromType == "m")
            {
                if (toType == "m")
                {
                    outputVal = value;
                }
                else if (toType == "mm")
                {
                    outputVal = value * 1000;
                }
                else if (toType == "cm")
                {
                    outputVal = value * 100;
                }
                else if (toType == "mi")
                {
                    outputVal = value * 0.000621371192;
                }
                else if (toType == "in")
                {
                    outputVal = value * 39.3700787;
                }
                else if (toType == "km")
                {
                    outputVal = value * 0.001;
                }
                else if (toType == "ft")
                {
                    outputVal = value * 3.2808399;
                }
                else if (toType == "yd")
                {
                    outputVal = value * 1.0936133;
                }
            }
            else if (fromType == "mm")
            {
                cal = value / 1000;

                if (toType == "m")
                {
                    outputVal = cal;
                }
                else if (toType == "mm")
                {
                    outputVal = value;
                }
                else if (toType == "cm")
                {
                    outputVal = cal * 100;
                }
                else if (toType == "mi")
                {
                    outputVal = cal * 0.000621371192;
                }
                else if (toType == "in")
                {
                    outputVal = cal * 39.3700787;
                }
                else if (toType == "km")
                {
                    outputVal = cal * 0.001;
                }
                else if (toType == "ft")
                {
                    outputVal = cal * 3.2808399;
                }
                else if (toType == "yd")
                {
                    outputVal = cal * 1.0936133;
                }
            }
            else if (fromType == "cm")
            {
                cal = value / 100;

                if (toType == "m")
                {
                    outputVal = cal;
                }
                else if (toType == "mm")
                {
                    outputVal = cal * 1000;
                }
                else if (toType == "cm")
                {
                    outputVal = value;
                }
                else if (toType == "mi")
                {
                    outputVal = cal * 0.000621371192;
                }
                else if (toType == "in")
                {
                    outputVal = cal * 39.3700787;
                }
                else if (toType == "km")
                {
                    outputVal = cal * 0.001;
                }
                else if (toType == "ft")
                {
                    outputVal = cal * 3.2808399;
                }
                else if (toType == "yd")
                {
                    outputVal = cal * 1.0936133;
                }
            }
            else if (fromType == "mi")
            {
                cal = value / 0.000621371192;

                if (toType == "m")
                {
                    outputVal = cal;
                }
                else if (toType == "mm")
                {
                    outputVal = cal * 1000;
                }
                else if (toType == "cm")
                {
                    outputVal = cal * 100;
                }
                else if (toType == "mi")
                {
                    outputVal = value;
                }
                else if (toType == "in")
                {
                    outputVal = cal * 39.3700787;
                }
                else if (toType == "km")
                {
                    outputVal = cal * 0.001;
                }
                else if (toType == "ft")
                {
                    outputVal = cal * 3.2808399;
                }
                else if (toType == "yd")
                {
                    outputVal = cal * 1.0936133;
                }
            }
            else if (fromType == "in")
            {
                cal = value / 39.3700787;

                if (toType == "m")
                {
                    outputVal = cal;
                }
                else if (toType == "mm")
                {
                    outputVal = cal * 1000;
                }
                else if (toType == "cm")
                {
                    outputVal = cal * 100;
                }
                else if (toType == "mi")
                {
                    outputVal = cal * 0.000621371192;
                }
                else if (toType == "in")
                {
                    outputVal = value;
                }
                else if (toType == "km")
                {
                    outputVal = cal * 0.001;
                }
                else if (toType == "ft")
                {
                    outputVal = cal * 3.2808399;
                }
                else if (toType == "yd")
                {
                    outputVal = cal * 1.0936133;
                }
            }
            else if (fromType == "km")
            {
                cal = value / 0.001;

                if (toType == "m")
                {
                    outputVal = cal;
                }
                else if (toType == "mm")
                {
                    outputVal = cal * 1000;
                }
                else if (toType == "cm")
                {
                    outputVal = cal * 100;

                }
                else if (toType == "mi")
                {
                    outputVal = cal * 0.000621371192;
                }
                else if (toType == "in")
                {
                    outputVal = cal * 39.3700787;
                }
                else if (toType == "km")
                {
                    outputVal = value;
                }
                else if (toType == "ft")
                {
                    outputVal = cal * 3.2808399;
                }
                else if (toType == "yd")
                {
                    outputVal = cal * 1.0936133;
                }
            }
            else if (fromType == "ft")
            {
                cal = value / 3.2808399;

                if (toType == "m")
                {
                    outputVal = cal;
                }
                else if (toType == "mm")
                {
                    outputVal = cal * 1000;
                }
                else if (toType == "cm")
                {
                    outputVal = cal * 100;
                }
                else if (toType == "mi")
                {
                    outputVal = cal * 0.000621371192;
                }
                else if (toType == "in")
                {
                    outputVal = cal * 39.3700787;
                }
                else if (toType == "km")
                {
                    outputVal = cal * 0.001;
                }
                else if (toType == "ft")
                {
                    outputVal = value;
                }
                else if (toType == "yd")
                {
                    outputVal = cal * 1.0936133;
                }
            }
            else if (fromType == "yd")
            {
                cal = value / 1.0936133;

                if (toType == "m")
                {
                    outputVal = cal;
                }
                else if (toType == "mm")
                {
                    outputVal = cal * 1000;
                }
                else if (toType == "cm")
                {
                    outputVal = cal * 100;
                }
                else if (toType == "mi")
                {
                    outputVal = cal * 0.000621371192;
                }
                else if (toType == "in")
                {
                    outputVal = cal * 39.3700787;
                }
                else if (toType == "km")
                {
                    outputVal = cal * 0.001;
                }
                else if (toType == "ft")
                {
                    outputVal = cal * 3.2808399;
                }
                else if (toType == "yd")
                {
                    outputVal = value;
                }
            }

            Console.WriteLine($"{outputVal} {toType}");
        }
    }
}
