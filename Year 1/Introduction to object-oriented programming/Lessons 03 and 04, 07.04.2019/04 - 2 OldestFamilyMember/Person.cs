using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___2_OldestFamilyMember
{
    class Person
    {
        private string name;
        private sbyte age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public sbyte Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return $"{name} {age}";
        }
    }
}
