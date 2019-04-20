using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___1_SalaryRas
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public void IncreaseSalary(double bonus)
        {
            if (Age < 30) bonus /= 2;

            salary += salary * bonus / 100;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} get {Salary:F2} leva";
        }

        public string FirstName
        {
            get { return firstName; }
            private set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public double Salary
        {
            get { return salary; }
            private set { salary = value; }
        }
    }
}
