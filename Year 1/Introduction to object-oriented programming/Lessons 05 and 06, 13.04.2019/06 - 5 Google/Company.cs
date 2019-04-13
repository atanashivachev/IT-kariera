using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___5_Google
{
    class Company
    {
        private string name;
        private string department;
        private float salary;

        public Company() { }

        public Company(string name, string department, float salary)
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name} {Department} {Salary:F2}";
        }

        public string Department { get => department; set => department = value; }
        public float Salary { get => salary; set => salary = value; }
        public string Name { get => name; set => name = value; }
    }
}
