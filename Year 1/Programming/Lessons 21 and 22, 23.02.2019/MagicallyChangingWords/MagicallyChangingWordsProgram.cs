using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicallyChangingWords
{
    class MagicallyChangingWordsProgram
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            char[] string1 = input[0].Select(x => x).Distinct().ToArray();
            char[] string2 = input[1].Select(x => x).Distinct().ToArray();

            bool exchangable = false;

            if (string1.Length == string2.Length)
            {
                exchangable = true;
            }

            Console.WriteLine(exchangable);
        }
    }
}
