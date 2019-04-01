using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfNames2
{
    class ListOfNames2Program
    {
        static void Main(string[] args)
        {
            //po uslovie, input e razdelen sus zapetaiki, makar i primera da e razdelen sus zapetaq i rastoqnie, spored mene tva e zaradi avtomatichniq space sled zapetaq pri MS Word
            List<string> input = Console.ReadLine().Split(',').ToList();

            foreach (string fullName in input)
            {
                List<string> names = fullName.Split(' ').Reverse().ToList();
                Console.WriteLine(string.Join(" ", names));
            }
        }
    }
}
