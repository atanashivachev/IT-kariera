using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerOfTwoValues
{
    class BiggerOfTwoValuesProgram
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            var value1 = Console.ReadLine();
            var value2 = Console.ReadLine();

            switch(dataType)
            {
                case "int": Console.WriteLine(BiggerInt(int.Parse(value1), int.Parse(value2))); break;
                case "char": Console.WriteLine(BiggerChar(char.Parse(value1), char.Parse(value2))); break;
                case "string": Console.WriteLine(BiggerString(value1, value2)); break;
            }
        }
        static int BiggerInt(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
        static char BiggerChar(char ch1, char ch2)
        {
            if (ch1 > ch2) return ch1;
            else return ch2;
        }
        static string BiggerString(string str1, string str2)
        {
            for (int i = 0; i < Math.Max(str1.Length, str2.Length); i++)
            {
                if (str1[i] > str2[i]) return str1;
                else if (str1[i] < str2[i]) return str2;
            }

            if (str1.Length > str2.Length) return str1;
            else return str2;
        }
    }
}
