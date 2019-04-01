using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool mid = false;

            for (int i = 0; i < 2 * (n - 2) + 1; i++)
            {
                if (i == n - 2 && mid == false) { Console.WriteLine(new string(' ', (2 * n - 2) / 2) + "@" + new string(' ', (2 * n - 2) / 2)); mid = true; }
                else if (i % 2 == 0 && mid == false) Console.WriteLine(new string('*', (2 * n - 4) / 2) + "\\" + " " + "/" + new string('*', (2 * n - 4) / 2));
                else if (i % 2 != 0 && mid == false) Console.WriteLine(new string('-', (2 * n - 4) / 2) + "\\" + " " + "/" + new string('-', (2 * n - 4) / 2));               
                else if (i % 2 == 0 && mid == true) Console.WriteLine(new string('*', (2 * n - 4) / 2) + "/" + " " + "\\" + new string('*', (2 * n - 4) / 2));
                else if (i % 2 != 0 && mid == true) Console.WriteLine(new string('-', (2 * n - 4) / 2) + "/" + " " + "\\" + new string('-', (2 * n - 4) / 2));
            }
        }
    }
}
