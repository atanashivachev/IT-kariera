﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string day = null;

            switch (a)
            {
                case 1: day = "Monday"; break;
                case 2: day = "Tuesday"; break;
                case 3: day = "Wednesday"; break;
                case 4: day = "Thursday"; break;
                case 5: day = "Friday"; break;
                case 6: day = "Saturday"; break;
                case 7: day = "Sunday"; break;
                default: day = "Error"; break;
            }
            Console.WriteLine(day);
        }
    }
}
