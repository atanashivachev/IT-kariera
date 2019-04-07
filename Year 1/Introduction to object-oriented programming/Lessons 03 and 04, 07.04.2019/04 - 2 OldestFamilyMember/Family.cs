using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___2_OldestFamilyMember
{
    class Family
    {
        private List<Person> members;

        public List<Person> Members
        {
            set {members = value;}
            get {return members;}
        }

        public void AddMember(Person mem)
        {
            members.Add(mem);
        }

        public Person OldestMember()
        {
            return members.OrderByDescending(p => p.Age).First();
        }
    }
}
