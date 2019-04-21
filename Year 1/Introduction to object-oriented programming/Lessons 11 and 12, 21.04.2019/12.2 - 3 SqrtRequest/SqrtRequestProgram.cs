using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2___3_SqrtRequest
{
    class SqrtRequestProgram
    {
        static void Main(string[] args)
        {
            for(int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                int num = int.Parse(Console.ReadLine());

                try
                {
                    Sqrt.Request(num);
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            }
        }
    }
}
