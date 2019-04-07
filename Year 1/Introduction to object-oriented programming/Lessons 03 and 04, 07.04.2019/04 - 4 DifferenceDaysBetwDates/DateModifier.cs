using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___4_DifferenceDaysBetwDates
{
    class DateModifier
    {
        public static int Days (string date1String, string date2String)
        {
            //yyyy MM dd
            int[] date1A = date1String.Split(' ').Select(int.Parse).ToArray();
            int[] date2A = date2String.Split(' ').Select(int.Parse).ToArray();

            //DateTime is in System;
            DateTime date1 = new DateTime(date1A[0], date1A[1], date1A[2]);
            DateTime date2 = new DateTime(date2A[0], date2A[1], date2A[2]);

            return Math.Abs((date1 - date2).Days);
        }
    }
}
