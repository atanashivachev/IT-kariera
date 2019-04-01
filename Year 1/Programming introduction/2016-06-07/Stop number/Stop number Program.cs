using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int p = 0;

            for (; ; )
            {
                if (p == s || m == n) break;
                if (m % 2 == 0 && m % 3 == 0) { Console.Write(m + " "); p = n; }
                m--;
            }
        }
    }
}
