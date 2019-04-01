using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = n - 1;
            int b = 1;

            Console.WriteLine(new string(' ', n) + " | ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', a) + new string('*', b) + " | " + new string('*', b));
                b += 1;
                a -= 1;
                Console.WriteLine();
            }     
        }
    }
}
