using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___3_Shopping
{
    class Product
    {
        private string name;
        public int price;

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                { throw new ArgumentException("Name cannot be an empty string"); }

                name = value;
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                { throw new ArgumentException("Price cannot be negative"); }

                price = value;
            }
        }
    }
}
