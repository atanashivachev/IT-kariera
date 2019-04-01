using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfBigNumbers
{
    class SumOfBigNumbersProgram
    {
        static void Main(string[] args)
        {
            //BigInteger and BigDecimal can't be used in this task

            var num1 = Console.ReadLine().Select(x => int.Parse(x + "")).Reverse().ToList();
            var num2 = Console.ReadLine().Select(x => int.Parse(x + "")).Reverse().ToList();

            while (num1.Count != num2.Count)
            {
                if (num1.Count > num2.Count) num2.Add(0);
                else num1.Add(0);
            }

            int[] sum = new int[num1.Count + 1];

            for (int i = 0; i < num1.Count; i++)
            {
                sum[i] += num1[i] + num2[i];

                if (sum[i] > 9)
                {
                    sum[i] %= 10;
                    sum[i + 1] += 1;
                }
            }

            Array.Reverse(sum);
            if (sum[0] == 0) sum[0] = 10;
            Console.WriteLine(string.Join("", sum.Where(x => x != 10)));
        }
    }
}
