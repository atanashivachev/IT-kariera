using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Family
{
    class Family
    {
        private List<Person> people = new List<Person>();

        public void AddMember(Person member)
        {
            people.Add(member);
        }

        //PresentFamily = print
        public void PresentFamily()
        {
            foreach(var member in people)
            {
                Console.WriteLine(member.Name + " " + member.Age);
            }
        }
    }
}
