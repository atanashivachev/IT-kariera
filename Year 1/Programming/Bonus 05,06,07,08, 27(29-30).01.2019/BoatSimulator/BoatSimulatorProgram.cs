using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatSimulator
{
    class BoatSimulatorProgram
    {
        static void Main(string[] args)
        {
            char boat1 = Console.ReadLine()[0];
            char boat2 = Console.ReadLine()[0];
            byte rows = byte.Parse(Console.ReadLine());
            int length1 = 0;
            int length2 = 0;

            for (byte i = 1; i <= rows; i++)
            {
                string word = Console.ReadLine();
                if (i % 2 == 0)
                {
                    if (word != "UPGRADE") length2 += word.Length;
                    else { boat1 = (char)(boat1 + 3); boat2 = (char)(boat2 + 3); }
                }
                else
                {
                    if (word != "UPGRADE") length1 += word.Length;
                    else { boat1 = (char)(boat1 + 3); boat2 = (char)(boat2 + 3); }
                }

                if (length1 >= 50) { Console.WriteLine(boat1); rows = 0; break; }
                if (length2 >= 50) { Console.WriteLine(boat2); rows = 0; break; }
            }

            if (rows != 0)
            {
                if (length1 > length2) Console.WriteLine(boat1);
                else Console.WriteLine(boat2);
            }
        }
    }
}
