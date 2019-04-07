using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___2_OldestFamilyMember
{
    class OldestFamilyMemberProgram
    {
        static void Main(string[] args)
        {
            Family myFamily = new Family();
            myFamily.Members = new List<Person>();

            for(int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();

                myFamily.AddMember(new Person { Name = info[0], Age = sbyte.Parse(info[1])});
            }

            Console.WriteLine(myFamily.OldestMember().ToString());
        }
    }
}
