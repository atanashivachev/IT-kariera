using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();
            Middle();
            Lower();
        }
        static void Middle()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void Lower()
        {
            Line();
            Console.WriteLine("© SoftUni");
        }
        static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Line();
        }
        static void Line()
        {
            Console.WriteLine("------------------------------");
        }
    }
}
