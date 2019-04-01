using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmuneSystem
{
    class ImmuneSystemProgram
    {
        static void Main(string[] args)
        {
            int strengthImmuneSystem = int.Parse(Console.ReadLine());
            int maxImmuneStrength = strengthImmuneSystem;
            var viruses = new List<string>();

            int oldStrength = 0;
            int virusDefeatSeconds = 0;
            string previousVirus = null;

            while (true)
            {
                string virus = Console.ReadLine();

                if (virus.Equals("end"))
                {
                    Console.WriteLine($"Final Health: {strengthImmuneSystem + (strengthImmuneSystem * 1 / 5)}");
                    break;
                }
                else
                {
                    int strengthVirus = virus.Select(x => (int)x).Sum() / 3;

                    if (viruses.Contains(virus) && !virus.Equals(previousVirus)) virusDefeatSeconds = strengthVirus * virus.Length / 3;
                    else virusDefeatSeconds = strengthVirus * virus.Length;

                    Console.WriteLine($"Virus {virus}: {strengthVirus} => {virusDefeatSeconds}");

                    strengthImmuneSystem -= virusDefeatSeconds;
                    //20% = 20 /100 = 1 / 5
                    strengthImmuneSystem += oldStrength * 1 / 5;

                    if (strengthImmuneSystem < 0) { Console.WriteLine("Immune System Defeated."); break; }
                    else
                    {
                        Console.WriteLine($"{virus} defeated in {virusDefeatSeconds / 60}m {virusDefeatSeconds % 60}s.");
                        if (strengthImmuneSystem > maxImmuneStrength) strengthImmuneSystem = maxImmuneStrength;

                        Console.WriteLine($"Remaining health: {strengthImmuneSystem}");
                    }

                    viruses.Add(virus);
                    oldStrength = strengthImmuneSystem;
                    previousVirus = virus;
                }
            }
        }
    }
}
