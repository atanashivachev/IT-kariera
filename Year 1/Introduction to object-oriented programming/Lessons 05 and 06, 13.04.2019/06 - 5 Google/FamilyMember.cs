using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___5_Google
{
    class FamilyMember
    {
        private string name;
        private string birthDate;

        public FamilyMember(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{Name} {BirthDate}";
        }

        public string Name { get => name; set => name = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
    }
}
