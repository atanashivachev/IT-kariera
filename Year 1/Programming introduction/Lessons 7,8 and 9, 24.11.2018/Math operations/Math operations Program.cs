using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            double result = 0;
            string oddeven = null;

            switch (op)
            {
                case "+": result = N1 + N2;
                    if (result % 2 == 0) oddeven = "even";
                    else oddeven = "odd"; break;
                case "-": result = N1 - N2;
                    if (result % 2 == 0) oddeven = "even";
                    else oddeven = "odd"; break;
                case "*": result = N1 * N2;
                    if (result % 2 == 0) oddeven = "even";
                    else oddeven = "odd"; break;
                case "%": 
                    if (N2 == 0) break;
                    else result = N1 % N2; break;
                case "/":
                    if (N2 == 0) break;
                    else result = N1 / N2; break;
            }
            
            switch (op)
            {
                case "+":
                case "-":
                case "*": Console.WriteLine($"{N1} {op} {N2} = {result} - {oddeven}"); break;
                case "%": Console.WriteLine($"{N1} {op} {N2} = {result}");
                    if (N2 == 0) Console.WriteLine($"Cannot divide {N1} by zero");
                    else Console.WriteLine($"{N1} {op} {N2} = {result}"); break;
                case "/":
                    if (N2 == 0) Console.WriteLine($"Cannot divide {N1} by zero");
                    else Console.WriteLine($"{N1} {op} {N2} = {result}"); break;
            }
        }
    }
}
