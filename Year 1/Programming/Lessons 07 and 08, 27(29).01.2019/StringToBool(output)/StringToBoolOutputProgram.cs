using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToBoolOutput
{
    class StringToBoolOutputProgram
    {
        static void Main(string[] args)
        {
            bool input = Convert.ToBoolean(Console.ReadLine());
            if (input == true) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
