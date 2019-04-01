using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendEMail
{
    class SendEMailProgram
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
                sum += sB[i];
            }
            return sum;
        }
    }
}
