using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSumProgram
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length / 4;

            int[] firstEnds = input.Take(k).Reverse().ToArray();
            int[] lastEnds = input.Reverse().Take(k).ToArray();
            int[] ends = firstEnds.Concat(lastEnds).ToArray();

            int[] mid = input.Skip(k).Take(k * 2).ToArray();
            int[] sum = new int[mid.Length];

            for (int i = 0; i < k * 2; i++)
            { sum[i] = ends[i] + mid[i];}

            //from presentation solve: .Select((x, index) => x + row2[index])

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
