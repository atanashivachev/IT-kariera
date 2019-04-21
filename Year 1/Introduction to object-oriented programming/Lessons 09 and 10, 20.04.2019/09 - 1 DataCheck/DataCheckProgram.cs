using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___1_DataCheck
{
    class DataCheckProgram
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();

                try
                {
                    people.Add(new Person(info[0], info[1], short.Parse(info[2]), double.Parse(info[3])));
                }
                catch (ArgumentException ex)
                { Console.WriteLine(ex.Message); }
            }

            people.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
