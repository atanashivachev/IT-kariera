using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___4_DifferenceDaysBetwDates
{
    class DifferenceDaysBetwDatesProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dates are in format yyyy MM dd");

            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            Console.WriteLine(DateModifier.Days(date1, date2));
        }
    }
}
