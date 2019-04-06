using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Defining_a_class_Person
{
    class DefiningClassPersonProgram
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();

            firstPerson.Name = "Gosho";
            firstPerson.Age = 28;

            //you can also do it like this
            Person secondPerson = new Person
            {
                Name = "Pesho",
                Age = 9
            };

            firstPerson.IntroduceYourself();
            secondPerson.IntroduceYourself();
        }
    }
}
