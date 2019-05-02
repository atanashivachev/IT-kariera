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

        private int ordered;
        private List<Product> Products;

        public void AddProduct (Product productToAdd)
        {
            Products.Add(productToAdd);
        }

        public bool ContainsProduct(string productName)
        {
            return Products.Count(x => x.Name == productName) > 0;
        }

        public void PrintRecipe()
        {
            Console.WriteLine(new string('-', 25));
            Console.WriteLine($"{Name} RECIPE");
            Console.WriteLine(new string('-', 25));

            Products.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine(new string('-', 25));
        }

        public void Order()
        {
            Ordered++;
        }

        public static Meal GetSpecialty(Dictionary<string, Meal> meals)
        {
            return meals.Values.OrderByDescending(m => m.Ordered).First();
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
            Products = products;
            Ordered = 0;
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
                if (value.Count(x => (x < 48 || x > 57) && (x < 65 || x > 90) && (x < 97 || x > 122)) > 0 || value.Length < 3)
                { throw new ArgumentException("Invalid Command!"); }

                name = value;
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                if (value.Count(x => (x < 48 || x > 57) && (x < 65 || x > 90) && (x < 97 || x > 122)) > 0 || value == "")
                { throw new ArgumentException("Invalid Command!"); }

                type = value;
            }
        }

        public double Price
        {
            get
            {
                price = Products.Sum(x => x.Price) + (30 * 1.0 / 100 * Products.Sum(x => x.Price));
                return price;
            }
            private set { price = value; }
        }

        public int Ordered
        {
            get { return ordered; }
            private set { ordered = value; }
        }
    }
}
