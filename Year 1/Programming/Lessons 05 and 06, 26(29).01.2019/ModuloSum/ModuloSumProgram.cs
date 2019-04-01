using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSum
{
    class ModuloSumProgram
    {
        static void Main(string[] args)
        {
            uint amountOfPairs = uint.Parse(Console.ReadLine());
            int sum = 0;

            for (uint i = 0; i < amountOfPairs; i++)
            {
                int divisible = int.Parse(Console.ReadLine());
                int divisor = int.Parse(Console.ReadLine());
                sum += divisible % divisor;
            }

            Console.WriteLine(sum);
        }
    }
}
