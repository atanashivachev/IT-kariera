using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _09___2_BoxDataVa
{
    class BoxDataValidateProgram
    {
        static void Main(string[] args)
        {
            //changed a bit the code from lesson 07, exercise 2 ClassBox

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //predetermined code, from the exercise

            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            //end of predermined code

            try
            {
                Box inputBox = new Box(length, width, height);

                Console.WriteLine($"Surface Area - {inputBox.SurfaceArea():F2}");
                Console.WriteLine($"Lateral Surface Area - {inputBox.LateralSurfaceArea():F2}");
                Console.WriteLine($"Volume - {inputBox.Volume():F2}");
            }
            catch (ArgumentException ex)
            { Console.WriteLine(ex.Message); }
        }
    }
}
