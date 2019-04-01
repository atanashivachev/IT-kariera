using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter e number in the range [1...100]:");
            int n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("Enter e number in the range [1...100]:");
                n = int.Parse(Console.ReadLine());
            }            
            Console.WriteLine($"The number is {n}");
        }
    }
}
