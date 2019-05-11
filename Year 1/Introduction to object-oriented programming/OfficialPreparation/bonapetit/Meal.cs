using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonapetit
{
    class Meal
    {
        private string name;
        private string type;
        private double price;

        private int timesOrdered;
        private List<Product> products;

        public void AddProduct (Product productToAdd)
        {
            products.Add(productToAdd);
        }

        public bool ContainsProduct(string productName)
        {
            return products.Count(p => p.Name == productName) > 0;
        }

        public void PrintRecipe()
        {
            Console.WriteLine(new string('-', 25));
            Console.WriteLine($"{Name} RECIPE");
            Console.WriteLine(new string('-', 25));

            products.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine(new string('-', 25));
        }

        public void Order()
        {
            TimesOrdered++;
        }

        public static Meal GetSpecialty(Dictionary<string, Meal> meals)
        {
            return meals.Values.OrderByDescending(m => m.TimesOrdered).First();
        }

        public static Meal RecommendByPrice (double price, Dictionary<string, Meal> meals)
        {
            return meals.Values.Where(m => m.Price <= price).OrderByDescending(m => m.Price).First();
        }

        public static Meal RecommendByPriceAndType(double price, string type, Dictionary<string, Meal> meals)
        {
            return meals.Values.Where(m => m.Price <= price && m.Type == type).OrderByDescending(m => m.Price).First();
        }

        public Meal(string name, string type) : this(name, type, new List<Product>())
        { }

        public Meal(string name, string type, List<Product> products)
        { 
            Name = name;
            Type = type;
            this.products = products;
            TimesOrdered = 0;
        }

        public override string ToString()
        {
            return $"{Name} - {Type}";
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                { throw new ArgumentException("Invalid Command!"); }

                name = value;
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                if (value == "")
                { throw new ArgumentException("Invalid Command!"); }

                type = value;
            }
        }

        public double Price
        {
            get
            {
                price = products.Sum(x => x.Price) + (30 * 1.0 / 100 * products.Sum(x => x.Price));
                return price;
            }
            private set { price = value; }
        }

        public int TimesOrdered
        {
            get { return timesOrdered; }
            private set { timesOrdered = value; }
        }
    }
}
