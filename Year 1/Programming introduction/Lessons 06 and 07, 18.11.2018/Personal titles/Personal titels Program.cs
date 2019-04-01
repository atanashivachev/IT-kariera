using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            string result = null;

            if (age < 16)
            {
                if (sex == "m") result = "Master";
                else if (sex == "f") result = "Miss"; 
            }
            else
            {
                if (sex == "m") result = "Mr.";
                else if (sex == "f") result = "Ms.";
            }
            Console.WriteLine(result);
        }
    }
}
