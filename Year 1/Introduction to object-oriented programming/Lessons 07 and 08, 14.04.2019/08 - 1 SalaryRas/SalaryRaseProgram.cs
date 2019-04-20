using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___1_SalaryRas
{
    class SalaryRaseProgram
    {
        static void Main(string[] args)
        {
            //predetermined code, from exercise

            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        double.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            var bonus = double.Parse(Console.ReadLine());

            //the next line is added, because they missed salary increase code
            persons.ForEach(p => p.IncreaseSalary(bonus));

            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
