using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hideout
{
    class HideoutProgram
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();

            for (; ; )
            {
                string[] clue = Console.ReadLine().Split(' ').ToArray();

                string hideout = new string(clue[0].ToCharArray().First(), int.Parse(clue[1].ToString()));

                if (map.Contains(hideout))
                {
                    int hIndex = map.IndexOf(hideout);
                    string fullHideout = map.Substring(hIndex, EndIndexOfSubstring(clue[0].ToCharArray().First(), hIndex, map) - hIndex);

                    Console.WriteLine($"Hideout found at index {hIndex} and it is with size {fullHideout.Length}!");
                    break;
                }
            }
        }

        static int EndIndexOfSubstring(char character, int firstIndex, string map)
        {
            int i = firstIndex;
            for ( ; i < map.Length; i++)
            {
                if (map[i] != character) break;
            }
            return i;
        }
    }
}
