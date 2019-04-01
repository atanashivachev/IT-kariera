using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            string fromCur = Console.ReadLine();
            string toCur = Console.ReadLine();

            if (fromCur == "m")
            {
                if (toCur == "m")
                {
                    Console.WriteLine(amount + " m");
                }
                if (toCur == "mm")
                {
                    Console.WriteLine(amount * 1000 + " mm");
                }
                else if (toCur == "cm")
                {
                    Console.WriteLine(amount * 100 + " cm");
                }
                else if (toCur == "mi")
                {
                    Console.WriteLine(amount * 0.000621371192 + " mi");
                }
                else if (toCur == "in")
                {
                    Console.WriteLine(amount * 39.3700787 + " in");
                }
                else if (toCur == "km")
                {
                    Console.WriteLine(amount * 0.001 + " km");
                }
                else if (toCur == "ft")
                {
                    Console.WriteLine(amount * 3.2808399 + " ft");
                }
                else if (toCur == "yd")
                {
                    Console.WriteLine(amount * 1.0936133 + " yd");
                }
            }
            else if (fromCur == "mm")
            {
                if (toCur == "mm")
                {
                    Console.WriteLine(amount + " mm");
                }
                if (toCur == "m")
                {
                    Console.WriteLine(amount / 1000 + " m");

                }
                else if (toCur == "cm")
                {
                    Console.WriteLine(amount * 0.1 + " cm");

                }
                else if (toCur == "mi")
                {
                    Console.WriteLine(amount * (0.000621371192 / 1000) + " mi");

                }
                else if (toCur == "in")
                {
                    Console.WriteLine(amount * (39.3700787 / 1000) + " in");

                }
                else if (toCur == "km")
                {
                    Console.WriteLine(amount * (0.001 / 1000) + " km");

                }
                else if (toCur == "ft")
                {
                    Console.WriteLine(amount * (3.2808399 / 1000) + " ft");

                }
                else if (toCur == "yd")
                {
                    Console.WriteLine(amount * (1.0936133 / 1000) + " yd");

                }
            }
            else if (fromCur == "cm")
            {
                if (toCur == "cm")
                {
                    Console.WriteLine(amount + " cm");
                }
                if (toCur == "m")
                {
                    Console.WriteLine(amount / 100 + " m");
                }
                else if (toCur == "mm")
                {
                    Console.WriteLine(amount * (1000 / 100) + " mm");
                }
                else if (toCur == "mi")
                {
                    Console.WriteLine(amount * (0.000621371192 / 100) + " mi");
                }
                else if (toCur == "in")
                {
                    Console.WriteLine(amount * (39.3700787 / 100) + " in");
                }
                else if (toCur == "km")
                {
                    Console.WriteLine(amount * (0.001 / 100) + " km");
                }
                else if (toCur == "ft")
                {
                    Console.WriteLine(amount * (3.2808399 / 100) + " ft");
                }
                else if (toCur == "yd")
                {
                    Console.WriteLine(amount * (1.0936133 / 100) + " yd");
                }
            }
            else if (fromCur == "mi")
            {
                if (toCur == "mi")
                {
                    Console.WriteLine(amount + " mi");
                }
                if (toCur == "m")
                {
                    Console.WriteLine(amount / 0.000621371192 + " m");
                }
                else if (toCur == "mm")
                {
                    Console.WriteLine(amount * (1000 / 0.000621371192) + " mm");
                }
                else if (toCur == "cm")
                {
                    Console.WriteLine(amount * (100 / 0.000621371192) + " cm");
                }
                else if (toCur == "in")
                {
                    Console.WriteLine(amount * (39.3700787 / 0.000621371192) + " in");
                }
                else if (toCur == "km")
                {
                    Console.WriteLine(amount * (0.001 / 0.000621371192) + " km");
                }
                else if (toCur == "ft")
                {
                    Console.WriteLine(amount * (3.2808399 / 0.000621371192) + " ft");
                }
                else if (toCur == "yd")
                {
                    Console.WriteLine(amount * (1.0936133 / 0.000621371192) + " yd");
                }
            }
            else if (fromCur == "in")
            {
                if (toCur == "in")
                {
                    Console.WriteLine(amount + " in");
                }
                if (toCur == "m")
                {
                    Console.WriteLine(amount / 39.3700787 + " m");
                }
                else if (toCur == "mm")
                {
                    Console.WriteLine(amount * (1000 / 39.3700787) + " mm");
                }
                else if (toCur == "cm")
                {
                    Console.WriteLine(amount * (100 / 39.3700787) + " cm");
                }
                else if (toCur == "mi")
                {
                    Console.WriteLine(amount * (0.000621371192 / 39.3700787) + " mi");
                }
                else if (toCur == "km")
                {
                    Console.WriteLine(amount * (0.001 / 39.3700787) + " km");
                }
                else if (toCur == "ft")
                {
                    Console.WriteLine(amount * (3.2808399 / 39.3700787) + " ft");
                }
                else if (toCur == "yd")
                {
                    Console.WriteLine(amount * (1.0936133 / 39.3700787) + " yd");
                }
            }
            else if (fromCur == "km")
            {
                if (toCur == "km")
                {
                    Console.WriteLine(amount + " km");
                }
                if (toCur == "m")
                {
                    Console.WriteLine(amount / 0.001 + " m");
                }
                else if (toCur == "mm")
                {
                    Console.WriteLine(amount * (1000 / 0.001) + " mm");
                }
                else if (toCur == "cm")
                {
                    Console.WriteLine(amount * (100 / 0.001) + " cm");
                }
                else if (toCur == "mi")
                {
                    Console.WriteLine(amount * (0.000621371192 / 0.001) + " mi");
                }
                else if (toCur == "in")
                {
                    Console.WriteLine(amount * (39.3700787 / 0.001) + " in");
                }
                else if (toCur == "ft")
                {
                    Console.WriteLine(amount * (3.2808399 / 0.001) + " ft");
                }
                else if (toCur == "yd")
                {
                    Console.WriteLine(amount * (1.0936133 / 0.001) + " yd");
                }
            }
            else if (fromCur == "ft")
            {
                if (toCur == "ft")
                {
                    Console.WriteLine(amount + " ft");
                }
                if (toCur == "m")
                {
                    Console.WriteLine(amount / 3.2808399 + " m");

                }
                else if (toCur == "mm")
                {
                    Console.WriteLine(amount * (1000 / 3.2808399) + " mm");

                }
                else if (toCur == "cm")
                {
                    Console.WriteLine(amount * (100 / 3.2808399) + " cm");

                }
                else if (toCur == "mi")
                {
                    Console.WriteLine(amount * (0.000621371192 / 3.2808399) + " mi");

                }
                else if (toCur == "in")
                {
                    Console.WriteLine(amount * (39.3700787 / 3.2808399) + " in");

                }
                else if (toCur == "km")
                {
                    Console.WriteLine(amount * (0.001 / 3.2808399) + " km");

                }
                else if (toCur == "yd")
                {
                    Console.WriteLine(amount * (1.0936133 / 3.2808399) + " yd");

                }
            }
            else if (fromCur == "yd")
            {
                if (toCur == "yd")
                {
                    Console.WriteLine(amount + " yd");
                }
                if (toCur == "m")
                {
                    Console.WriteLine(amount / 1.0936133 + " m");

                }
                else if (toCur == "cm")
                {
                    Console.WriteLine(amount * (100 / 1.0936133) + " cm");

                }
                else if (toCur == "mm")
                {
                    Console.WriteLine(amount * (1000 / 1.0936133) + " mm");

                }
                else if (toCur == "mi")
                {
                    Console.WriteLine(amount * (0.000621371192 / 1.0936133) + " mi");

                }
                else if (toCur == "km")
                {
                    Console.WriteLine(amount * (0.001 / 1.0936133) + " km");

                }
                else if (toCur == "in")
                {
                    Console.WriteLine(amount * (39.3700787 / 1.0936133) + " in");

                }
                else if (toCur == "ft")
                {
                    Console.WriteLine(amount * (3.2808399 / 1.0936133) + " ft");

                }
            }
        }
    }
}
