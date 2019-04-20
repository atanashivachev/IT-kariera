using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _07___2_ClassBox
{
    class ClassBoxProgram
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //predetermined code, from the exercise

            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            //end of predermined code

            Box inputBox = new Box(length, width, height);

            Console.WriteLine($"Surface Area - {inputBox.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {inputBox.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {inputBox.Volume():F2}");
        }
    }
}
