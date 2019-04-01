using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());      
            h -= 1;

            double workPlaceH = Math.Floor(h / 0.7);
            double workPlaceW = Math.Floor(w / 1.2);

            Console.WriteLine(workPlaceH * workPlaceW - 3);
        }
    }
}
