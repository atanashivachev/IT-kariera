using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class HexToDecimalProgram
    {
        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();
            Int64 intNum = Convert.ToInt64(hexNum, 16);
            Console.WriteLine(intNum);
        }
    }
}
