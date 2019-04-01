using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = (n * 2) - 1;
            int b = n;
            bool mid = false;

            
            Console.WriteLine(new string('.', n + 1) + new string('_', (n * 2) + 1) + new string('.', n + 1));
            for (int i = 0; i < (n * 2) + 1; i++)
            {
                if (b == 0 && mid == false) { Console.WriteLine("//" + new string('_', (a / 2) - 2) + "STOP!" + new string('_', (a / 2) - 2) + "\\" + "\\"); mid = true; }
                else if (mid == false)
                {
                    Console.WriteLine(new string('.', b) + "//" + new string('_', a) + "\\" + "\\" + new string('.', b));
                    b--;
                    a += 2;
                }
                else if (mid == true)
                {
                    Console.WriteLine(new string('.', b) + "\\" + "\\" + new string('_', a) + "//" + new string('.', b));
                    b++;
                    a -= 2;
                }
            }
        }
       
    }
}
