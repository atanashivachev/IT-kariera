using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsForPizza
{
    class ProductsForPizzaProgram
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split(' ').ToList();
            int prodLength = int.Parse(Console.ReadLine());
            var usedProds = new List<string>();

            foreach (var prod in products)
            {
                if (prod.Length == prodLength)
                {
                    Console.WriteLine($"Adding {prod}");
                    usedProds.Add(prod);
                }
            }

            Console.WriteLine($"Made pizza with total of {usedProds.Count} ingredients. The ingredients are: {string.Join(" ", usedProds)}.");
        }
    }
}
