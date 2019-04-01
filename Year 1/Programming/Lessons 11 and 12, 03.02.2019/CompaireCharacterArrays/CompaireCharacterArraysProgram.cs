using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaireCharacterArrays
{
    class CompaireCharacterArraysProgram
    {
        static void Main(string[] args)
        {
            char[] input1 = Console.ReadLine().Split(' ').Select(Convert.ToChar).ToArray();
            char[] input2 = Console.ReadLine().Split(' ').Select(Convert.ToChar).ToArray();
            int bigger = 0;

            for (int i = 0; i < Math.Min(input1.Length, input2.Length); i++)
            {
                if (bigger != 0) break;

                if (input1[i] > input2[i]) { bigger = 2; break;}
                else if (input1[i] < input2[i]) { bigger = 1; break;}
            }

            if (bigger == 1) Console.WriteLine($"{string.Join("", input1)}\r\n{string.Join("", input2)}");
            else if (bigger == 2) Console.WriteLine($"{string.Join("", input2)}\r\n{string.Join("", input1)}");
            else
            { 
                if (input2.Length < input1.Length) Console.WriteLine($"{string.Join("", input2)}\r\n{string.Join("", input1)}");
                else Console.WriteLine($"{string.Join("", input1)}\r\n{string.Join("", input2)}");
            }
        }
    }
}
