using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1___1_Shop
{
    class Product
    {
        private string name;
        private string barCode;
        private double price;
        private double quantity;

        public Product(string name, string barCode, double price, double quantity)
        {
            Name = name;
            BarCode = barCode;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{name} ({barCode})";
        }

        public string Name { get => name; set => name = value; }
        public string BarCode { get => barCode; set => barCode = value; }
        public double Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }
    }
}
