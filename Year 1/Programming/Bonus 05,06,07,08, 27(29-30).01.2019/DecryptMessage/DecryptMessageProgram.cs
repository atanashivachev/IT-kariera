using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptMessage
{
    class DecryptMessageProgram
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            byte rows = byte.Parse(Console.ReadLine());
            string message = null;

            for (byte i = 0; i < rows; i++)
            {
                char letter = Console.ReadLine()[0];
                letter = (char)(letter + key);
                message += letter;
            }
            Console.WriteLine(message);
        }
    }
}
