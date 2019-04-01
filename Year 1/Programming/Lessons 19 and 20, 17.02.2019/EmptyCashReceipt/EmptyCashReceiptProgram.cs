using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyCashReceipt
{
    class EmptyCashReceiptProgram
    {
        static void Main(string[] args)
        {
            Header();
            ChargeReceive();
            Footer();
        }
        static void Line()
        {
            Console.WriteLine("------------------------------");
        }
        static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Line();
        }
        static void ChargeReceive()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void Footer()
        {
            Line();
            Console.WriteLine("© SoftUni");
        }
    }
}
