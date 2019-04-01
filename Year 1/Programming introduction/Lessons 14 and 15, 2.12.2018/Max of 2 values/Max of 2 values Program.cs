using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_of_2_values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int input = int.Parse(Console.ReadLine());
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine(IntCalc(input, input1));
            }
            else if (type == "char")
            {
                char input = Console.ReadLine()[0];
                char input1 = Console.ReadLine()[0];
                Console.WriteLine(CharCalc(input, input1));
            }
            else if (type == "string")
            {
                string input = Console.ReadLine();
                string input1 = Console.ReadLine();
                Console.WriteLine(StringCalc(input, input1));
            }
        }
        static int IntCalc(int a, int b)
        {
            return Math.Max(a, b);
        }
        static char CharCalc(char a, char b)
        {
            if (a > b) return a;
            else return b;
        }
        static string StringCalc(string str, string str1)
        {
            if (str.CompareTo(str1) > 0) return str;
            else return str1;        
        }
    }
}
