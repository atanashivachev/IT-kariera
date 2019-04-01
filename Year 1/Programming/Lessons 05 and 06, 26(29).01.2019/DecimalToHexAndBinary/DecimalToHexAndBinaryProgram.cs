using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexAndBinary
{
    class DecimalToHexAndBinaryProgram
    {
        static void Main(string[] args)
        {
            long inputNum = long.Parse(Console.ReadLine());
            string hexNum = Convert.ToString(inputNum, 16);
            
            string binaryNum = Convert.ToString(inputNum, 2);

            Console.WriteLine($"{hexNum.ToUpper()}\r\n{binaryNum}");
        }
    }
}
