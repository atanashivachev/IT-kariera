using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___2_AnimalFar
{
    class AnimalFarmProgram
    {
        static void Main(string[] args)
        {
            //for more information on how to solve the exercise (and to see unspecified code, that should be specified in the task) go to:
            //https://github.com/hammer4/SoftUni/tree/master/C%23%20Basics%20OOP/4.%20Encapsulation%20Exercises/03.%20Animal%20Farm

            Chicken myChicken = new Chicken();

            try //on output we don't need to only return an exception, but we want to see only the exception message
            {
                myChicken.Name = Console.ReadLine();
                myChicken.Age = int.Parse(Console.ReadLine());
                Console.WriteLine(myChicken.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}
