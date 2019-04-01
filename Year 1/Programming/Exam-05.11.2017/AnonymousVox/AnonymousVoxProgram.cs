using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousVox
{
    class AnonymousVoxProgram
    {
        static void Main(string[] args)
        {
            StringBuilder encodedText = new StringBuilder(Console.ReadLine());
            string[] placeholders = Console.ReadLine().Split('{', '}').Where(x => x != "").ToArray();

            int placeholderPosition = 0;
            for (int scanStartIndex = 0; scanStartIndex < encodedText.Length; scanStartIndex++)
            {
                List<char> start = new List<char>();

                int lastOccuranceIndex = -1;
                int indicatorLength = -1;

                for (int eTPos = scanStartIndex; eTPos < encodedText.Length; eTPos++)
                {
                    start.Add(encodedText[eTPos]);

                    for (int eTPosLast = encodedText.Length - start.Count; eTPosLast > eTPos + 1; eTPosLast--)
                    {
                        if (encodedText.ToString().Substring(eTPosLast, start.Count).CompareTo(string.Join("", start)) == 0 && 
                            encodedText.ToString().Substring(eTPosLast, start.Count).All(x => (x > 64 && x < 91) || (x > 96 && x < 123)))
                        {
                            lastOccuranceIndex = eTPosLast;
                            indicatorLength = start.Count;
                            break;
                        }
                    }
                }

                if (lastOccuranceIndex > -1 && placeholderPosition < placeholders.Length)
                {
                    encodedText.Remove(scanStartIndex + indicatorLength, lastOccuranceIndex - scanStartIndex - indicatorLength);
                    encodedText.Insert(scanStartIndex + indicatorLength, placeholders[placeholderPosition]);

                    scanStartIndex += 2 * indicatorLength + placeholders[placeholderPosition].Length;
                    placeholderPosition++;
                }
            }

            Console.WriteLine(encodedText);

        }
    }
}
