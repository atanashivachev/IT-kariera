using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___6_FamilyTre
{
    class FamilyTreeProgram
    {
        static void Main(string[] args)
        {
            Family myFamily = new Family();

            string memberInfo = Console.ReadLine();
            if (memberInfo.Contains('/')) myFamily.Member.BirthDate = memberInfo;
            else myFamily.Member.Name = memberInfo;

            while (true)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();

                if (info[0] == "End") break;

                if (!info.Contains("-")) // Име Фамилия ден/месец/година
                {
                    if(myFamily.Children.Contains(new Person(null, info[2])))
                    { myFamily.Children.Find(c => c.BirthDate == info[2]).Name = info[0] + info[1]; }
                    else if (myFamily.Parents.Contains(new Person(null, info[2])))
                    { myFamily.Parents.Find(c => c.BirthDate == info[2]).Name = info[0] + info[1]; }

                    else if (myFamily.Children.Contains(new Person(info[0] + info[1], null)))
                    { myFamily.Children.Find(c => c.Name == info[0] + info[1]).BirthDate = info[2]; }
                    else if (myFamily.Parents.Contains(new Person(info[0] + info[1], null)))
                    { myFamily.Parents.Find(c => c.Name == info[0] + info[1]).BirthDate = info[2]; }

                    else
                    { myFamily.Members.Add(new Person(info[0] + info[1], info[2])); }
                }
                else
                {
                    if (info[0].Contains('/'))
                    {
                        if (info[2].Contains('/')) // ден/месец/година - ден/месец/година
                        {
                            
                        }
                        else // ден/месец/година - Име Фамилия
                        {

                        }
                    }
                    else if (info[3].Contains('/')) // Име Фамилия - ден/месец/година
                    {

                    }
                    else // Име Фамилия - Име Фамилия
                    {

                    }
                }
            }
        }
    }
}
