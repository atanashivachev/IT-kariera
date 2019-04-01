using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendEMailUnicode
{
    class SendEMailUnicodeProgram
    {
        static void Main(string[] args)
        {
            StringBuilder eMailAdress = new StringBuilder(Console.ReadLine());
            int positionOfAt = eMailAdress.ToString().IndexOf('@');

            StringBuilder personal = new StringBuilder(eMailAdress.ToString().Substring(0, positionOfAt));
            StringBuilder mailSite = new StringBuilder(eMailAdress.ToString().Substring(positionOfAt + 1, eMailAdress.Length - positionOfAt - 1));

            if (SumOfChars(personal) - SumOfChars(mailSite) >= 0) Console.WriteLine("Call her!");
            else Console.WriteLine("She is not the one.");
        }

        static int SumOfChars(StringBuilder sB)
        {
            int sum = 0;
            for (int i = 0; i < sB.Length; i++)
            {
                //completely pointless, because hexadecimal numbers are stored as a int, but to transform to hex you have to make it a string and then transform the string to int
                sum += Convert.ToInt32(Convert.ToString(sB[i], 16), 16);
            }
            return sum;
        }
    }
}

