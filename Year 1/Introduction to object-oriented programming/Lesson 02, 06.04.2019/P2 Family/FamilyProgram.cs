using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Family
{
    class FamilyProgram
    {
        static void Main(string[] args)
        {
            Family myFamily = new Family();

            for(int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();

                myFamily.AddMember(new Person{ Name = info[0], Age = byte.Parse(info[1])});
            }

            myFamily.PresentFamily();
        }
    }
}
