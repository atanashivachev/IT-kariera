using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumbers
{
    class MultiplyBigNumbersProgram
    {
        static void Main(string[] args)
        {
            //BigInteger and BigDecimal can't be used in this task

            var num1 = Console.ReadLine().Select(x => int.Parse(x + "")).Reverse().ToList();
            var num2 = Console.ReadLine().Select(x => int.Parse(x + "")).Reverse().ToList();

            int[] sum = new int[num1.Count + num2.Count];
            
            for (int i = 0; i < Math.Max(num1.Count, num2.Count); i++)
            {
                for (int j = 0, k = i; j < Math.Min(num1.Count, num2.Count); j++, k++)
                {
                    sum[k] += num2[j] * num1[i];

                    if (sum[k] > 9)
                    {
                        sum[k + 1] += sum[k] / 10;
                        sum[k] %= 10;                     
                    }
                }
            }

            Array.Reverse(sum);
            if (sum[0] == 0) sum[0] = 10;
            Console.WriteLine(string.Join("", sum.Where(x => x != 10)));
        }
    }
}
