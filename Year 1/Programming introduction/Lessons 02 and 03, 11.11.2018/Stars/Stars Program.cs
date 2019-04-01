using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (string a = "*"; a != "***********"; a = a + "*")
            {
                Console.WriteLine(a);
            }
        }
    }
}
