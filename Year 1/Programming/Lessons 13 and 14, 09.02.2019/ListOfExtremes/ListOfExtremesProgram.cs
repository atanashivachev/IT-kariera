using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfExtremes
{
    class ListOfExtremesProgram
    {
        static void Main(string[] args)
        {
            List<Int32> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();

            var extremeNums = new List<Int32>();
            extremeNums.Add(input[0]);
            extremeNums.Add(input[input.Count - 1]);

            for(int i = 0; i < input.Count; i++)
            {
                if (input[i] == extremeNums[0] && i != 0) extremeNums.Insert(0, input[i]);
                else if (input[i] == extremeNums[extremeNums.Count - 1]&& i != input.Count - 1) extremeNums.Insert(extremeNums.Count - 1, input[i]);
            }

            Console.WriteLine(string.Join(" ", extremeNums));
        }
    }
}
