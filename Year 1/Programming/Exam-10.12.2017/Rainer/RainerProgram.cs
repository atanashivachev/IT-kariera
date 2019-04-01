using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainer
{
    class RainerProgram
    {
        static void Main(string[] args)
        {
            byte[] initalValues = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();

            byte position = initalValues[initalValues.Length - 1];
            byte[] values = new byte[initalValues.Length - 1];
            Array.Copy(initalValues, values, initalValues.Length - 1);

            int steps = 0;
            while (true)
            {
                values = values.Select(x => (byte)(x - 1)).ToArray();

                if (values[position] == 0) break; 

                if (values.Contains((byte)0))
                {
                    for (int i = 0; i < values.Length; i++) if (values[i] == 0) values[i] = initalValues[i];
                }

                position = byte.Parse(Console.ReadLine());
                steps++;
            }

            Console.WriteLine(string.Join(" ", values));
            Console.WriteLine(steps);
        }
    }
}
