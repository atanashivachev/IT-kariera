using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___3_Shopping
{
    class ShoppingProgram
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> customers = Console.ReadLine().Split(';').Where(x => x != "")
                            .Select(s => new Person(s.Split('=').First(), int.Parse(s.Split('=').Last())))
                            .ToList();

                List<Product> products = Console.ReadLine().Split(';').Where(x => x != "")
                          .Select(s => new Product(s.Split('=').First(), int.Parse(s.Split('=').Last())))
                          .ToList();

                while (true)
                {
                    string[] order = Console.ReadLine().Split(' ').ToArray();
                    if (order[0] == "END") break;

                    try
                    {
                        if (customers.Count(c => c.Name == order[0]) < 1)
                        { throw new ArgumentException("Customer does not exist"); }

                        if (products.Count(c => c.Name == order[1]) < 1)
                        { throw new ArgumentException("Product does not exist"); }

                        customers.Find(c => c.Name == order[0]).Buy(products.Find(p => p.Name == order[1]));
                    }
                    catch (ArgumentException ex)
                    { Console.WriteLine(ex.Message); }
                }

                customers.ForEach(c => Console.WriteLine(c));
            }
            catch (ArgumentException ex)
            { Console.WriteLine(ex.Message); }
        }
    }
}
