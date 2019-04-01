using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceTheThief
{
    class SentenceTheThiefProgram
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            byte row = byte.Parse(Console.ReadLine());
            float max = 0;

            switch (type)
            {
                case "sbyte": max = sbyte.MaxValue; break;
                case "int": max = int.MaxValue; break;
                case "long": max = long.MaxValue; break;
            }

            float biggest = long.MinValue;

            for (byte i = 0; i < row; i++)
            {
                long n = long.Parse(Console.ReadLine());
                if (n < max && biggest < n) biggest = n;
            }

            if (biggest >= 0) max = sbyte.MaxValue;               
            else max = sbyte.MinValue;

            uint years = Convert.ToUInt32(Math.Ceiling(biggest / max));

            string plural = null;
            if (years != 1) plural = "s";

            Console.WriteLine($"Prisoner with id {biggest} is sentenced to {years} year{plural}");
        }
    }
}
