using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("/" + new string('^', n/2) + '\\' + new string('_', (n * 2) - (4 + n/2 * 2)) + "/" + new string('^', n / 2) + '\\');

            for (int i = 0; i < n - 2; i++)
            {
                if (i == n - 3) Console.WriteLine("|" + new string(' ', n / 2 + 1) + new string('_', (n * 2) - (4 + n / 2 * 2)) + new string(' ', n / 2 + 1) + "|");
                else Console.WriteLine("|"+ new string(' ', n * 2 - 2) +"|");
            }

            Console.WriteLine("\\" + new string('^', n / 2) + '/' + new string(' ', (n * 2) - (4 + n / 2 * 2)) + "\\" + new string('^', n / 2) + '/');           
        }
    }
}
