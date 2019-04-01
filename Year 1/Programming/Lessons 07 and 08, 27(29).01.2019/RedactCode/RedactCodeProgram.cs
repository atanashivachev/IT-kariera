using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedactCode
{
    class RedactCodeProgram
    {
        static void Main(string[] args)
        {
            /*code to be redacted
            
            double dul, sh, V = 0;
            Console.Write("Length: ");
            dul = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            sh = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            V = double.Parse(Console.ReadLine());
            V = (dul + sh + V) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", V);

            */

            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Heigth: ");
            double heigth = double.Parse(Console.ReadLine());

            double volume = (length + width + heigth) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:F2}");
        }
    }
}
