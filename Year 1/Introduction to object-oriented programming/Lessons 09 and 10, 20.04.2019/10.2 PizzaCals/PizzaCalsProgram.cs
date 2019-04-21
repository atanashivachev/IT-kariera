using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_PizzaCals
{
    class PizzaCalsProgram
    {
        static void Main(string[] args)
        {
            Pizza myPizza = null;
            List<Topping> top = new List<Topping>();

            try
            {
                while (true)
                {
                    string[] info = Console.ReadLine().Split(' ').ToArray();
                    if (info[0].ToLower() != "pizza") info = info.Select(x => x.ToLower()).ToArray();

                    if (info[0] == "end") break;

                    switch (info[0])
                    {
                        case "Pizza": myPizza = new Pizza(info[1], int.Parse(info[2])); break;
                        case "dough": myPizza.PizzaDough = new Dough(info[1], info[2], int.Parse(info[3])); break;
                        case "topping": top.Add(new Topping(info[1], int.Parse(info[2]))); break;
                    }
                }

                myPizza.PizzaToppings = top.Select(x => x).ToArray();

                Console.WriteLine(myPizza);
            }
            catch (ArgumentException ex)
            { Console.WriteLine(ex.Message); }
        }
    }
}
