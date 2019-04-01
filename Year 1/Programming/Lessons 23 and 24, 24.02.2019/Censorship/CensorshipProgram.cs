using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Censorship
{
    class CensorshipProgram
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            StringBuilder censor = new StringBuilder(Console.ReadLine());

            //one of the few useful features of StringBuilder, alongside with .ToString and .Append
            text.Replace(censor.ToString(), new string('*', censor.Length));
            
            Console.WriteLine(text);
        }
    }
}
