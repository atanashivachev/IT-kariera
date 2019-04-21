using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___3_Shopping
{
    class Person
    {
        private string name;
        private int money;
        private List<Product> productsBag;

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            productsBag = new List<Product>();
        }

        public void Buy(Product purchase)
        {
            if (purchase.Price > Money)
            { throw new ArgumentException($"{Name} can't afford {purchase.Name}"); }

            ProductsBag.Add(purchase);
            Money -= purchase.Price;

            Console.WriteLine($"{Name} bought {purchase.Name}");
        }

        public override string ToString()
        {
            if (productsBag.Count == 0) return $"{Name} - Nothing bought";

            return $"{Name} - {string.Join(", ", productsBag.Select(p => p.Name))}";
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

        public int Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                { throw new ArgumentException("Money cannot be negative"); }

                money = value;
            }
        }

        public List<Product> ProductsBag
        {
            get { return productsBag; }
            private set { productsBag = value; }
        }
    }
}
