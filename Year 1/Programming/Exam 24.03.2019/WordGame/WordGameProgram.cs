using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{
    class WordGameProgram
    {
        static void Main(string[] args)
        {
            //solved in 12 min, 100/100 points

            int maxPoints = 0;
            string biggestString = null;

            while (true)
            {
                string word = Console.ReadLine();
                if (word.Equals("END OF GAME")) break;
                int points = PointsCalculatior(word);

                if (points > maxPoints)
                {
                    maxPoints = points;
                    biggestString = word;
                }
            }

            Console.WriteLine($"Winner is word: {biggestString}");
            Console.WriteLine($"Points: {maxPoints}");
        }

        static int PointsCalculatior(string word)
        {
            int points = 0;

            foreach (char letter in word)
            {
                points += letter;
            }

            if (word.First() > 64 && word.First() < 91) points += 15;
            if (word.Last().Equals('t')) points += 20;
            if (word.Length >= 10) points += 30;

            return points;
        }
    }
}
