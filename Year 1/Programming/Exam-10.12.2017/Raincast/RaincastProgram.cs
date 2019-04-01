using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raincast
{
    class RaincastProgram
    {
        static void Main(string[] args)
        {
            string[] raincast = new string[3];
            while (true)
            {
                string input = Console.ReadLine();

                if (input.StartsWith("Type: ") && raincast[0] == null &&
                    (input.Substring(6) == "Normal" || input.Substring(6) == "Warning" || input.Substring(6) == "Danger"))
                {
                    raincast[0] = input.Substring(6);
                }
                else if (input.StartsWith("Source: ") && raincast[1] == null && raincast[0] != null &&
                    input.Substring(8).All(x => (x > 47 && x < 58) || (x > 64 && x < 91) || (x > 96 && x < 123)))
                {
                    raincast[1] = input.Substring(8);
                }
                else if (input.StartsWith("Forecast: ") && raincast[2] == null && raincast [0] != null && raincast[1] != null &&
                    input.Substring(10).All(x => x != '!' && x != '.' && x != ',' && x != '?'))
                {
                    raincast[2] = input.Substring(10);
                }
                else if (input.Equals("Davai Emo")) break;

                if (raincast.All(x => x != null))
                {
                    Console.WriteLine($"({raincast[0]}) {raincast[2]} ~ {raincast[1]}");
                    raincast = raincast.Select(x => x = null).ToArray();
                }
            }
        }
    }
}
