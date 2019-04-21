using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2___1_defineClassPerson
{
    class Person
    {
        private static uint objects;
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            objects++;
        }

        public static uint PersonCount
        {
            get { return objects; }
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
}
