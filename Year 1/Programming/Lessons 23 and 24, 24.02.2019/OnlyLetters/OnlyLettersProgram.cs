using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyLetters
{
    class OnlyLettersProgram
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };      

            for (int i = input.IndexOfAny(digits); i < input.Length - 1; i++)
            {
                if (input.IndexOfAny(digits) == i) input = input.Replace(input[i], input[i + 1]);
                if (input.IndexOfAny(digits) == i)
                {
                    if (AnyLettersAfter(i, input) == false) break;

                    input = input.Remove(i, 1);
                    i--;
                }
            }

            Console.WriteLine(input);
        }

        static bool AnyLettersAfter(int index, string input)
        {
            //this method checks if there will be any letters after the numbers; in cases where the input ends with a number, that number must not be changed
            for ( ; index < input.Length; index++)
            {
                if (input[index] != '0' && input[index] != '1' && input[index] != '2' &&
                    input[index] != '3' && input[index] != '4' && input[index] != '5' &&
                    input[index] != '6' && input[index] != '7' && input[index] != '8' &&
                    input[index] != '9') return true;
            }
            return false;
        }
    }
}
