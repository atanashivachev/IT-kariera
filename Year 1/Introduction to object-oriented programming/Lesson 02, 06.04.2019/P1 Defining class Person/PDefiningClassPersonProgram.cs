using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1__Defining_of_class_Person
{
    class PDefiningClassPersonProgram
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person { name = "Pesho", age = 32};

            //the task wanted this block of code, without explaining any of it, the code even requires System.Reflections
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }
}
