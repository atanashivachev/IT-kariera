using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonapetit
{
    class Product
    {
        private string name;
        private int weight;
        private double price;

        public static Product GetCheapestProduct(Dictionary<string, Product> products)
        {
            return products.Values.OrderBy(p => p.Price).First();
        }


        public Product(string name, double price, int weight)
        {
            Name = name;
            Weight = weight;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Weight}";
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

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 1000)
                { throw new ArgumentException("Invalid Command!"); }

                weight = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0.01)
                { throw new ArgumentException("Invalid Command!"); }

                price = value;
            }
        }
    }
}
