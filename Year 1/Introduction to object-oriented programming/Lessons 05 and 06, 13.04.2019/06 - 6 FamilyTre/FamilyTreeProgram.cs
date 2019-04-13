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
            List<Person> family = new List<Person>();

            string memberInfo = Console.ReadLine();
            if (memberInfo.Contains('/'))
            {
                int[] mInfo = memberInfo.Where(x => !x.Equals('/')).Select(x => int.Parse(x + "")).ToArray();
                family.Add(new Person(new DateTime(mInfo[2], mInfo[1], mInfo[0])));
            }
            else family.Add(new Person(memberInfo));

            while (true)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();
                int[] dates = InfoToDatesArray(info);

                 

                if (info[0] == "End") break;

                if (!info.Contains("-")) // Име Фамилия ден/месец/година
                {
                    Person tempPerson = new Person(info[0] + " " + info[1], new DateTime(dates[2], dates[1], dates[0]));

                    if(family.Where(x => x.BirthDate == tempPerson.BirthDate).Count() > 0 &&
                        family.Where(x => x.Name == tempPerson.Name).Count() > 0)
                    {
                        family.Find(x => x.Name == tempPerson.Name).Merge(family.Find(x => x.BirthDate == tempPerson.BirthDate));
                        family.RemoveAll(x => x.BirthDate == tempPerson.BirthDate && x.Name == null);
                    }

                    else if (family.Where(x => x.BirthDate == tempPerson.BirthDate).Count() > 0)
                    { family.Find(p => p.BirthDate == tempPerson.BirthDate).Name = tempPerson.Name; }

                    else if (family.Where(x => x.Name == tempPerson.Name).Count() > 0)
                    { family.Find(p => p.Name == tempPerson.Name).BirthDate = tempPerson.BirthDate; }

                    else family.Add(tempPerson); 
                }
                else
                {
                    if (info[0].Contains('/'))
                    {
                        if (info[2].Contains('/')) // ден/месец/година - ден/месец/година
                        {
                            Person tempPerson1 = new Person(new DateTime(dates[2], dates[1], dates[0]));
                            Person tempPerson2 = new Person(new DateTime(dates[5], dates[4], dates[3]));

                            if (family.Where(p => p.BirthDate == tempPerson1.BirthDate).Count() == 0)
                            { family.Add(tempPerson1); }

                            if(family.Where(p => p.BirthDate == tempPerson2.BirthDate).Count() == 0)
                            { family.Add(tempPerson2); }

                            family.Find(p => p.BirthDate == tempPerson1.BirthDate).Children.Add(family.Find(p => p.BirthDate == tempPerson2.BirthDate));
                            family.Find(p => p.BirthDate == tempPerson2.BirthDate).Parents.Add(family.Find(p => p.BirthDate == tempPerson1.BirthDate));
                        }
                        else // ден/месец/година - Име Фамилия
                        {
                            Person tempPerson1 = new Person(new DateTime(dates[2], dates[1], dates[0]));
                            Person tempPerson2 = new Person(info[2] + " " + info[3]);

                            if (family.Where(p => p.BirthDate == tempPerson1.BirthDate).Count() == 0)
                            { family.Add(tempPerson1); }

                            if(family.Where(p => p.Name == tempPerson2.Name).Count() == 0)
                            { family.Add(tempPerson2); }

                            family.Find(p => p.BirthDate == tempPerson1.BirthDate).Children.Add(family.Find(p => p.Name == tempPerson2.Name));
                            family.Find(p => p.Name == tempPerson2.Name).Parents.Add(family.Find(p => p.BirthDate == tempPerson1.BirthDate));
                        }
                    }
                    else if (info[3].Contains('/')) // Име Фамилия - ден/месец/година
                    {
                        Person tempPerson1 = new Person(info[0] + " " + info[1]);
                        Person tempPerson2 = new Person(new DateTime(dates[2], dates[1], dates[0]));
                        
                        if (family.Where(p => p.Name == tempPerson1.Name).Count() == 0)
                        { family.Add(tempPerson1); }

                        if (family.Where(p => p.BirthDate == tempPerson2.BirthDate).Count() == 0)
                        { family.Add(tempPerson2); }

                        family.Find(p => p.Name == tempPerson1.Name).Children.Add(family.Find(p => p.BirthDate == tempPerson2.BirthDate));
                        family.Find(p => p.BirthDate == tempPerson2.BirthDate).Parents.Add(family.Find(p => p.Name == tempPerson1.Name));   
                    }
                    else // Име Фамилия - Име Фамилия
                    {
                        Person tempPerson1 = new Person(info[0] + " " + info[1]);
                        Person tempPerson2 = new Person(info[3] + " " + info[4]);

                        if (family.Where(p => p.Name == tempPerson1.Name).Count() == 0)
                        { family.Add(tempPerson1); }

                        if (family.Where(p => p.Name == tempPerson2.Name).Count() == 0)
                        { family.Add(tempPerson2); }

                        family.Find(p => p.Name == tempPerson1.Name).Children.Add(family.Find(p => p.Name == tempPerson2.Name));
                        family.Find(p => p.Name == tempPerson2.Name).Parents.Add(family.Find(p => p.Name == tempPerson1.Name));
                    }
                }
            }

            Console.WriteLine(family[0].ToString());
        }

        private static int[] InfoToDatesArray(string[] info)
        {
            try
            {
                string datesString = string.Join("/", info.Where(x => x.Contains('/')));
                int[] dates = datesString.Split('/').Select(int.Parse).ToArray();
                return dates;
            }
            catch (Exception)
            { return null; }
        }
    }
}
