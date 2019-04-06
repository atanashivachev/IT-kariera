using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Defining_a_class_Person
{
    class Person
    {
        private string name;
        private byte age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public byte Age
        {
            get { return age; }
            set { age = value; }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Hello. My name is {name} and I am {age} years old.");
        }
    }
}
