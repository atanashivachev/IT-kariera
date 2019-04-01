using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLimits
{
    class TypeLimitsProgram
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "int": Console.WriteLine($"{int.MinValue}\r\n{int.MaxValue}"); break;
                case "uint": Console.WriteLine($"{uint.MinValue}\r\n{uint.MaxValue}"); break;
                case "long": Console.WriteLine($"{long.MinValue}\r\n{long.MaxValue}"); break;
                case "byte": Console.WriteLine($"{byte.MinValue}\r\n{byte.MaxValue}"); break;
                case "sbyte": Console.WriteLine($"{sbyte.MinValue}\r\n{sbyte.MaxValue}"); break;
            }               
        }
    }
}
