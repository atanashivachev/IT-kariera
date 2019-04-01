using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingOfShortWords
{
    class SortingOfShortWordsProgram
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ')
                .Where(x => x != "").Select(x => x.ToLower())
                .Distinct().Where(x => x.Length < 5)
                .OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
