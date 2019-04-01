using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04___6__double_bonus__1000_days
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "dd-MM-yyyy";
            string date = Console.ReadLine();
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime after = DateTime.ParseExact(date, format, provider);
            after = after.AddDays(999);
            Console.WriteLine("{0}", after.ToString(format));
        }
    }
}
