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
                int[] mInfo = memberInfo.Split('/').Select(x => int.Parse(x + "")).ToArray();

                family.Add(new Person(new DateTime(mInfo[2], mInfo[1], mInfo[0])));
                family.Single().ToBePrinted = true;
            }
            else
            {
                family.Add(new Person(memberInfo));
                family.Single().ToBePrinted = true;
            }

            while (true)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();
                int[] dates = InfoToDatesArray(info);

                if (info[0] == "End") break;

                if (!info.Contains("-")) // Име Фамилия ден/месец/година
                {
                    Person tempPerson = new Person(info[0] + " " + info[1], new DateTime(dates[2], dates[1], dates[0]));

                    //if we have two "people", i.e. one with only a name and other with only a birth date (and both with children and parents), 
                    //and we find out that they are one person, we need to merge them into one, so the name, birth date, children and parents are all in one place 
                    if(family.Count(x => x.BirthDate == tempPerson.BirthDate) > 0 &&
                                 family.Count(x => x.Name == tempPerson.Name) > 0)
                    {
                        family.Find(x => x.Name == tempPerson.Name).Merge(family.Find(x => x.BirthDate == tempPerson.BirthDate), family);
                    }

                    //searches for a person, whose birthdate matches the inputed birthdate, 
                    //i.e. checkes if there is any person that has that birth date, and then sets their name to the inputed one
                    //ifs like that work on the same principle
                    else if (family.Count(x => x.BirthDate == tempPerson.BirthDate) > 0)
                    {
                        family.Find(p => p.BirthDate == tempPerson.BirthDate).Name = tempPerson.Name;
                    }

                    else if (family.Count(x => x.Name == tempPerson.Name) > 0)
                    {
                        family.Find(p => p.Name == tempPerson.Name).BirthDate = tempPerson.BirthDate;
                    }

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

                            if (family.Count(p => p.BirthDate == tempPerson1.BirthDate) == 0)
                            { family.Add(tempPerson1); }

                            if(family.Count(p => p.BirthDate == tempPerson2.BirthDate) == 0)
                            { family.Add(tempPerson2); }

                            family.Find(p => p.BirthDate == tempPerson1.BirthDate).Children.Add(family.Find(p => p.BirthDate == tempPerson2.BirthDate));
                            family.Find(p => p.BirthDate == tempPerson2.BirthDate).Parents.Add(family.Find(p => p.BirthDate == tempPerson1.BirthDate));
                        }
                        else // ден/месец/година - Име Фамилия
                        {
                            Person tempPerson1 = new Person(new DateTime(dates[2], dates[1], dates[0]));
                            Person tempPerson2 = new Person(info[2] + " " + info[3]);

                            if (family.Count(p => p.BirthDate == tempPerson1.BirthDate) == 0)
                            { family.Add(tempPerson1); }

                            if(family.Count(p => p.Name == tempPerson2.Name) == 0)
                            { family.Add(tempPerson2); }

                            family.Find(p => p.BirthDate == tempPerson1.BirthDate).Children.Add(family.Find(p => p.Name == tempPerson2.Name));
                            family.Find(p => p.Name == tempPerson2.Name).Parents.Add(family.Find(p => p.BirthDate == tempPerson1.BirthDate));
                        }
                    }
                    else if (info[3].Contains('/')) // Име Фамилия - ден/месец/година
                    {
                        Person tempPerson1 = new Person(info[0] + " " + info[1]);
                        Person tempPerson2 = new Person(new DateTime(dates[2], dates[1], dates[0]));
                        
                        if (family.Count(p => p.Name == tempPerson1.Name) == 0)
                        { family.Add(tempPerson1); }

                        if (family.Count(p => p.BirthDate == tempPerson2.BirthDate) == 0)
                        { family.Add(tempPerson2); }

                        family.Find(p => p.Name == tempPerson1.Name).Children.Add(family.Find(p => p.BirthDate == tempPerson2.BirthDate));
                        family.Find(p => p.BirthDate == tempPerson2.BirthDate).Parents.Add(family.Find(p => p.Name == tempPerson1.Name));   
                    }
                    else // Име Фамилия - Име Фамилия
                    {
                        Person tempPerson1 = new Person(info[0] + " " + info[1]);
                        Person tempPerson2 = new Person(info[3] + " " + info[4]);

                        if (family.Count(p => p.Name == tempPerson1.Name) == 0)
                        { family.Add(tempPerson1); }

                        if (family.Count(p => p.Name == tempPerson2.Name) == 0)
                        { family.Add(tempPerson2); }

                        family.Find(p => p.Name == tempPerson1.Name).Children.Add(family.Find(p => p.Name == tempPerson2.Name));
                        family.Find(p => p.Name == tempPerson2.Name).Parents.Add(family.Find(p => p.Name == tempPerson1.Name));
                    }
                }
            }

            Console.WriteLine(family.Find(p => p.ToBePrinted).ToString());
        }

        private static int[] InfoToDatesArray(string[] info)
        {
            try //the code splits the dates into integers, but if the input doesn't have dates, i.e. Pesho Peshev - Gancho Peshev, code will "blow"
            {
                //in case there are 2 dates, it makes them into one date, for example: 11/11/1951 - 23/5/1980 will be turned into 11/11/1951/23/5/1980
                string datesString = string.Join("/", info.Where(x => x.Contains('/')));
                //splits the "mega dates" (when two dates are combined, but there could be only 1 date) into integers
                int[] dates = datesString.Split('/').Select(int.Parse).ToArray();
                return dates;
            }
            catch (Exception)
            { return null; } //return null, because we don't have dates and will not need dates (case Име Фамилия - Име Фамилия)
        }
    }
}
