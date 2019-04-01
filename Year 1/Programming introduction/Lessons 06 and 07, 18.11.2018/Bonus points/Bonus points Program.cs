using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_points
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = int.Parse(Console.ReadLine());
            double points = 0;

            if (score <= 100)
            {
                points = 5;
            }
            else if (points <= 1000)
            {
                points = 0.2 * score;
            }
            else if (points > 1000)
            {
                points = 0.1 * score;
            }

            if (score % 2 == 0)
            {
                points += 1;
            }
            else if (score % 10 == 5)
            {
                points += 2;
            }

            Console.WriteLine(points);
            Console.WriteLine(points + score);
        }
    }
}
