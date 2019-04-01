using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+");
            for (int a1 = 0; a1 < (n - 2); a1++) Console.Write(" -");
            Console.WriteLine(" +");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|");
                for (int a2 = 0; a2 < (n - 2); a2++) Console.Write(" -");
                Console.WriteLine(" |");
            }

            Console.Write("+");
            for (int a3 = 0; a3 < (n - 2); a3++) Console.Write(" -");
            Console.WriteLine(" +");
        }
    }
}
