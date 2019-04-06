using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Statistics
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
    }
}
