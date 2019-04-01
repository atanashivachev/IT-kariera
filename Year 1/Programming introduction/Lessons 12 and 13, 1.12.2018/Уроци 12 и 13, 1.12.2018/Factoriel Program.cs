using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fact = 1;

            while (n > 0)
            {
                fact *= n;
                n--;
            }
            Console.WriteLine(fact);
        }
    }
}
