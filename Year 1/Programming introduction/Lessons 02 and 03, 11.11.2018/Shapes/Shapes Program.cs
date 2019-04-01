using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            string side = new string('*', times);
            Console.WriteLine(side);
            // От тука надолу проверих в интернет
            for (int i = 0; i < times - 2; i++)
            {
                Console.WriteLine('*' + new string(' ', times - 2) + "*");
            }
            // Без това последното разбира се
            Console.WriteLine(side);
        }
    }
}
