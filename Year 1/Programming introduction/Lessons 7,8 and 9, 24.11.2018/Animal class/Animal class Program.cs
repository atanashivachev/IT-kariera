using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_class
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            string aClass = null;

            switch (animal)
            {
                case "dog": aClass = "mammal"; break;
                case "crocodile":
                case "tortoise":
                case "snake": aClass = "reptile"; break;
                default: aClass = "unknown"; break;
            }
            Console.WriteLine(aClass);
        }
    }
}
