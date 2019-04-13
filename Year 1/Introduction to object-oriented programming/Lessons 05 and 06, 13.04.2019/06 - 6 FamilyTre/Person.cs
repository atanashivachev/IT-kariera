using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___6_FamilyTre
{
    class Person
    {
        private string name;
        private DateTime birthDate;

        private List<Person> parents;
        private List<Person> children;

        public void Merge (Person secondPerson)
        {
            birthDate = secondPerson.BirthDate;

            parents.AddRange(secondPerson.Parents);
            children.AddRange(secondPerson.Children);
            secondPerson.Parents.Select(p => p.Children.Remove(secondPerson)).ToArray();
            
            secondPerson.Children.Select(c => c.Parents.Remove(secondPerson)).ToArray();
        }

        public Person()
        {
            Parents = new List<Person>();
            Children = new List<Person>();
        }

        public Person(string name) : this(name, new DateTime())
        {
            Parents = new List<Person>();
            Children = new List<Person>();
        }

        public Person(DateTime birthDate) : this(null, birthDate)
        {
            Parents = new List<Person>();
            Children = new List<Person>();
        }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
            Parents = new List<Person>();
            Children = new List<Person>();
        }

        public override string ToString()
        {
            StringBuilder toReturn = new StringBuilder();
            toReturn.Append($"{Name} {BirthDate.Date}\r\nParents:\r\n");

            foreach(var parent in parents)
            { toReturn.Append($"{parent.Name} {parent.BirthDate.Date}\r\n"); }

            toReturn.Append($"Children:\r\n");

            foreach(var child in children)
            { toReturn.Append($"{child.Name} {child.BirthDate.Date}\r\n"); }

            return toReturn.ToString();
        }

        public string Name { get => name; set => name = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public List<Person> Parents { get => parents; set => parents = value; }
        public List<Person> Children { get => children; set => children = value; }
    }
}
