using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int t = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('$', t));
                t += 1;
            }
        }
    }
}
