using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Statistics
{
    class StatisticsProgram
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            for(int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();

                people.Add(new Person{ Name = info[0], Age = byte.Parse(info[1])});
            }

            foreach(var person in people.OrderBy(p => p.Name))
            {
                if (person.Age > 30) Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
