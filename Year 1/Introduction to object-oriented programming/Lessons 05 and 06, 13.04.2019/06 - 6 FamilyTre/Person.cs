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

        private bool toBePrinted;

        public void Merge (Person secondPerson, List<Person> family)
        {
            if (secondPerson.ToBePrinted) this.ToBePrinted = true;

            birthDate = secondPerson.BirthDate;

            parents.AddRange(secondPerson.Parents);
            children.AddRange(secondPerson.Children);

            //remove the old "person" and add the new, combined, person into the parents's list of children
            foreach(var parent in secondPerson.Parents)
            {
                parent.Children.Remove(secondPerson);
                parent.Children.Add(this);
            }

            //remove the old "person" and add the new, combined, person into the children's list of parents
            foreach (var child in children)
            {
                child.Parents.Remove(secondPerson);
                child.Parents.Add(this);
            }

            family.Remove(secondPerson);
        }

        public Person()
        {
            ToBePrinted = false;
            Parents = new List<Person>();
            Children = new List<Person>();
        }

        public Person(string name) : this(name, new DateTime())
        {
            toBePrinted = false;
            Parents = new List<Person>();
            Children = new List<Person>();
        }

        public Person(DateTime birthDate) : this(null, birthDate)
        {
            toBePrinted = false;
            Parents = new List<Person>();
            Children = new List<Person>();
        }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
            toBePrinted = false;
            Parents = new List<Person>();
            Children = new List<Person>();
        }

        public override string ToString()
        {
            StringBuilder toReturn = new StringBuilder();
            toReturn.Append($"{Name} {DateToString(BirthDate)}\r\nParents:\r\n");

            foreach(var parent in parents)
            { toReturn.Append($"{parent.Name} {DateToString(parent.BirthDate)}\r\n"); }

            toReturn.Append($"Children:\r\n");

            foreach(var child in children)
            { toReturn.Append($"{child.Name} {DateToString(child.BirthDate)}\r\n"); }

            return toReturn.ToString();
        }

        private string DateToString(DateTime birthDate)
        {
            return $"{birthDate.Day}/{birthDate.Month}/{birthDate.Year}";
        }

        public string Name { get => name; set => name = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public List<Person> Parents { get => parents; set => parents = value; }
        public List<Person> Children { get => children; set => children = value; }
        public bool ToBePrinted { get => toBePrinted; set => toBePrinted = value; }
    }
}
