using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Value: ");
            double inputValue = double.Parse(Console.ReadLine());

            Console.Write("Convert from: ");
            string inputType = Console.ReadLine();

            Console.Write("Convert to: ");
            string outputType = Console.ReadLine();

            double outputValue = 0;
            double meter = 0;

            if (inputType == "m")
            {
                if (outputType == "m")
                {
                    meter = inputValue;
                    outputValue = meter * 1;
                }
                else if (outputType == "mm")
                {
                    outputValue = inputValue * 1000;
                }
                else if (outputType == "cm")
                {
                    outputValue = inputValue * 100;
                }
                else if (outputType == "mi")
                {
                    outputValue = inputValue * 0.000621371192;
                }
                else if (outputType == "in")
                {
                    outputValue = inputValue * 39.3700787;
                }
                else if (outputType == "km")
                {
                    outputValue = inputValue * 0.001;
                }
                else if (outputType == "ft")
                {
                    outputValue = inputValue * 3.2808399;
                }
                else if (outputType == "yd")
                {
                    outputValue = inputValue * 1.0936133;
                }
            }
            if (inputType == "mm")
            {
                meter = inputValue / 1000;
                if (outputType == "m")
                {
                    outputValue = meter;
                }
                else if (outputType == "mm")
                {
                    outputValue = inputValue;
                }
                else if (outputType == "cm")
                {
                    outputValue = meter * 100;
                }
                else if (outputType == "mi")
                {
                    outputValue = meter * 0.000621371192;
                }
                else if (outputType == "in")
                {
                    outputValue = meter * 39.3700787;
                }
                else if (outputType == "km")
                {
                    outputValue = meter * 0.001;
                }
                else if (outputType == "ft")
                {
                    outputValue = meter * 3.2808399;
                }
                else if (outputType == "yd")
                {
                    outputValue = meter * 1.0936133;
                }
            }
            if (inputType == "cm")
            {
                meter = inputValue / 100;
                if (outputType == "m")
                {
                    outputValue = meter;
                }
                else if (outputType == "mm")
                {
                    outputValue = meter * 1000;
                }
                else if (outputType == "cm")
                {
                    outputValue = inputValue;
                }
                else if (outputType == "mi")
                {
                    outputValue = meter * 0.000621371192;
                }
                else if (outputType == "in")
                {
                    outputValue = meter * 39.3700787;
                }
                else if (outputType == "km")
                {
                    outputValue = meter * 0.001;
                }
                else if (outputType == "ft")
                {
                    outputValue = meter * 3.2808399;
                }
                else if (outputType == "yd")
                {
                    outputValue = meter * 1.0936133;
                }
            }
            if (inputType == "mi")
            {
                meter = inputValue / 0.000621371192;
                if (outputType == "m")
                {
                    outputValue = meter;
                }
                else if (outputType == "mm")
                {
                    outputValue = meter * 1000;
                }
                else if (outputType == "cm")
                {
                    outputValue = meter * 100;
                }
                else if (outputType == "mi")
                {
                    outputValue = inputValue;
                }
                else if (outputType == "in")
                {
                    outputValue = meter * 39.3700787;
                }
                else if (outputType == "km")
                {
                    outputValue = meter * 0.001;
                }
                else if (outputType == "ft")
                {
                    outputValue = meter * 3.2808399;
                }
                else if (outputType == "yd")
                {
                    outputValue = meter * 1.0936133;
                }
            }
            if (inputType == "in")
            {
                meter = inputValue / 39.3700787;
                if (outputType == "m")
                {
                    outputValue = meter;
                }
                else if (outputType == "mm")
                {
                    outputValue = meter * 1000;
                }
                else if (outputType == "cm")
                {
                    outputValue = meter * 100;
                }
                else if (outputType == "mi")
                {
                    outputValue = meter * 0.000621371192;
                }
                else if (outputType == "in")
                {
                    outputValue = inputValue;

                }
                else if (outputType == "km")
                {
                    outputValue = meter * 0.001;
                }
                else if (outputType == "ft")
                {
                    outputValue = meter * 3.2808399;
                }
                else if (outputType == "yd")
                {
                    outputValue = meter * 1.0936133;
                }
            }
            if (inputType == "km")
            {
                meter = inputValue / 0.001;
                if (outputType == "m")
                {
                    outputValue = meter;
                }
                else if (outputType == "mm")
                {
                    outputValue = meter * 1000;
                }
                else if (outputType == "cm")
                {
                    outputValue = meter * 100;
                }
                else if (outputType == "mi")
                {
                    outputValue = meter * 0.000621371192;
                }
                else if (outputType == "in")
                {
                    outputValue = meter * 39.3700787;

                }
                else if (outputType == "km")
                {
                    outputValue = inputValue;
                }
                else if (outputType == "ft")
                {
                    outputValue = meter * 3.2808399;
                }
                else if (outputType == "yd")
                {
                    outputValue = meter * 1.0936133;
                }
            }
            if (inputType == "ft")
            {
                meter = inputValue / 3.2808399;
                if (outputType == "m")
                {
                    outputValue = meter;
                }
                else if (outputType == "mm")
                {
                    outputValue = meter * 1000;
                }
                else if (outputType == "cm")
                {
                    outputValue = meter * 100;
                }
                else if (outputType == "mi")
                {
                    outputValue = meter * 0.000621371192;
                }
                else if (outputType == "in")
                {
                    outputValue = meter * 39.3700787;

                }
                else if (outputType == "km")
                {
                    outputValue = meter * 0.001;
                }
                else if (outputType == "ft")
                {
                    outputValue = inputValue;
                }
                else if (outputType == "yd")
                {
                    outputValue = meter * 1.0936133;
                }
            }
            if (inputType == "yd")
            {
                meter = inputValue / 1.0936133;
                if (outputType == "m")
                {
                    outputValue = meter;
                }
                else if (outputType == "mm")
                {
                    outputValue = meter * 1000;
                }
                else if (outputType == "cm")
                {
                    outputValue = meter * 100;
                }
                else if (outputType == "mi")
                {
                    outputValue = meter * 0.000621371192;
                }
                else if (outputType == "in")
                {
                    outputValue = meter * 39.3700787;

                }
                else if (outputType == "km")
                {
                    outputValue = meter * 0.001;
                }
                else if (outputType == "ft")
                {
                    outputValue = meter * 3.2808399;
                }
                else if (outputType == "yd")
                {
                    outputValue = inputValue;
                }
            }
            Console.WriteLine($"{outputValue} {outputType}");
        }
    }
}


