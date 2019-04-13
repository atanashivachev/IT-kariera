using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___6_FamilyTre
{
    class Family
    {
        private Person member;

        private List<Person> parents;

        private List<Person> children;

        private List<Person> members;

        public Family()
        {
            member = new Person();
            parents = new List<Person>();
            children = new List<Person>();
            members = new List<Person>();
        }

        public Person Member { get => member; set => member = value; }
        public List<Person> Parents { get => parents; set => parents = value; }
        public List<Person> Children { get => children; set => children = value; }
        public List<Person> Members { get => members; set => members = value; }
    }
}
