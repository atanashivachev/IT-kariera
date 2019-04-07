using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___3_ListOfEmployees
{
    class Employee
    {
        private string name;
        private double salary;
        private string job;
        private string department;
        private string email;
        private sbyte age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public sbyte Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return $"{name} {salary} {email} {age}";
        }
    }
}
