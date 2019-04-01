using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string Op = Console.ReadLine();

            switch (Op)
            {
                case "+":
                case "-":
                case "*": Console.WriteLine(PlusMinusMult(N1, N2, Op)); break;
                case "/": Console.WriteLine(Divide(N1, N2)); break;
                case "%": Console.WriteLine(ModuleDivide(N1, N2)); break; 
            }
        }
        static string PlusMinusMult(double N1, double N2, string Op)
        {
            double result = 0;
            string oddEven = null;

            switch (Op)
            {
                case "+": result = N1 + N2; break;
                case "-": result = N1 - N2; break;
                case "*": result = N1 * N2; break; 
            }

            if (result % 2 == 0) oddEven = "even";
            else oddEven = "odd";

            return $"{N1} {Op} {N2} = {result} - {oddEven}";
        }
        static string Divide(double N1, double N2)
        {
            double result = 0;
            if (N2 == 0) return $"Cannot divide {N1} by 0";
            else
            {
                result = N1 / N2;
                return $"{N1} / {N2} = {result:F2}";
            }
        }
        static string ModuleDivide(double N1, double N2)
        {
            double result = 0;
            if (N2 == 0) return $"Cannot divide {N1} by 0";
            else
            {
                result = N1 % N2;
                return $"{N1} % {N2} = {result}";
            }
        }
    }
}
