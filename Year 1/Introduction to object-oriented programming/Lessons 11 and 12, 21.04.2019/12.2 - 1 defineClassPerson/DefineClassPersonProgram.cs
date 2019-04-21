using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2___1_defineClassPerson
{
    class DefineClassPersonProgram
    {
        static void Main(string[] args)
        {
            List<Person> temp = new List<Person>();

            while (true)
            {
                string[] per = Console.ReadLine().Split(' ').ToArray();
                if (per[0] == "END") break;

                temp.Add(new Person(per[0], int.Parse(per[1])));
            }

            Console.WriteLine(Person.PersonCount);
        }
    }
}
