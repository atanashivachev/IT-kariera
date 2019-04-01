using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class IcarusProgram
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int position = int.Parse(Console.ReadLine());
            int damage = 1;

            while(true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "Supernova") break;

                for (int i = 0; i < int.Parse(command[1]) ; i++)
                {
                    if (command[0] == "left")
                    {
                        position--;
                        if (position == -1) { position = seq.Length - 1; damage++; }
                    }
                    else
                    {
                        position++;
                        if (position == seq.Length) { position = 0; damage++; }
                    }

                    seq[position] -= damage;
                }
            }

            Console.WriteLine(string.Join(" ", seq));
        }
    }
}
