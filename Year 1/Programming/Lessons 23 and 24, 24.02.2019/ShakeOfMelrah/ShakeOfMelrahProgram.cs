using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakeOfMelrah
{
    class ShakeOfMelrahProgram
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string template = Console.ReadLine();

            //the task requires a time of less than or equal to 250 milliseconds, the stopwatch counts time elapsed
            //DONT FORGET TO ADD System.Diagnostics IF YOU USE STOPWATCH

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            while (template.Length != 0 && input.Contains(template))
            {
                string original = input;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input.Substring(i, template.Length).CompareTo(template) == 0)
                    {
                        input = input.Remove(i, template.Length);
                        break;
                    }
                }

                if (input == original) break;

                for (int i = input.Length - template.Length; i > 0; i--)
                {
                    if (input.Substring(i, template.Length).CompareTo(template) == 0)
                    {
                        input = input.Remove(i, template.Length);
                        break;
                    }
                }

                if (input == original) break;
                
                Console.WriteLine("Shaked it.");
                template = template.Remove(template.Length / 2, 1);
            }


            Console.WriteLine("No shake.");
            Console.WriteLine(input);

            //the stopwatch time is shown in milliseconds, this can be changed to total time elapse by rewriting ElapsedMilliseconds to just Elapsed
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
