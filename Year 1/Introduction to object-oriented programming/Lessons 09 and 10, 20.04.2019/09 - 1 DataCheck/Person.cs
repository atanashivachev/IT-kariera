using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___1_DataCheck
{
    class Person
    {
        private string firstName;
        private string lastName;
        private short age;
        private double salary;

        public Person(string firstName, string lastName, short age, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 3)
                { throw new ArgumentException("First name cannot be less than 3 symbols"); }

                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length < 3)
                { throw new ArgumentException("Last name cannot be less than 3 symbols"); }

                lastName = value;
            }
        }

        public short Age
        {
            get { return age; }
            set
            {
                if (value < 1)
                { throw new ArgumentException("Age cannot be zero or negative integer"); }

                age = value;
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 460.0)
                { throw new ArgumentException("Salary cannot be less than 460 leva"); }

                salary = value;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} get {Salary:F1} leva";
        }
    }
}
