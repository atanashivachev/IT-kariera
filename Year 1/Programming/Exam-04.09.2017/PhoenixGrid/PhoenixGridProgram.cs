using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixGrid
{
    class PhoenixGridProgram
    {
        static void Main(string[] args)
        {
            //very very overcomplicated solution, do not use!
            
            while (true)
            {
                string[] message = MessageExtract();

                if (message[message.Length - 1] == "ReadMe") break;

                if (message[message.Length - 1] != "NO")
                {
                    bool bad = false;
                    foreach (string phrase in message)
                    {
                        if (phrase.Contains('_')) { bad = true; break; }
                        if (phrase.Contains(' ')) { bad = true; break; }

                        if (phrase.Length != 3 && phrase.Length != 0) { bad = true; break; }
                    }

                    if (!bad && Palindrome(message) && message.Length != 0) Console.WriteLine("YES");
                    else Console.WriteLine("NO");
                }
                else Console.WriteLine("NO");
            }
        }

        static string[] MessageExtract()
        {
            string input = Console.ReadLine();

            List<string> message = new List<string>();
            if (input.Length > 2)
            {
                message.Add(input.Substring(0, 3));

                if (input == "ReadMe") message.Add("ReadMe");
                else
                {
                    for (int i = 3; i < input.Length; i += 4)
                    {
                        if (input[i] != '.') { message.Add("NO"); break; }
                        else
                        {
                            if (i + 3 >= input.Length) { message.Add("NO"); break; }
                            else message.Add(input.Substring(i + 1, 3));
                        }
                    }
                }
            }
            else message.Add("NO");

            return message.ToArray();
        }

        static bool Palindrome(string[] message)
        {
            string messageS = string.Join("", message);
           
            char[] reverseMessageArray = string.Join("", message).ToCharArray().ToArray();
            Array.Reverse(reverseMessageArray);
            string messageR = string.Join("", reverseMessageArray);

            if (messageS == messageR && !messageS.Contains('\t')) return true;
            else return false;
        }
    }
}
