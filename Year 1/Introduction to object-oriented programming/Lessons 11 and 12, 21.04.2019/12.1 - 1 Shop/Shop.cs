using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1___1_Shop
{
    static class Shop
    {
        //                key is barcode, not product name
        static Dictionary<string, Product> shopProducts = new Dictionary<string, Product>();
        
        public static void SellProduct(string barCode, double quantity)
        {
            if (!shopProducts.ContainsKey(barCode) || shopProducts[barCode].Quantity < quantity)
            { throw new ArgumentException("Not enough quantity"); }

            shopProducts[barCode].Quantity -= quantity;
        }

        public static void AddProduct(string name, string barCode, double price, double quantity)
        {
            Product toAdd = new Product(name, barCode, price, quantity);
            shopProducts.Add(barCode, toAdd);
        }

        public static void UpdateProduct(string barCode, double quantity)
        {
            if (!shopProducts.ContainsKey(barCode))
            { throw new ArgumentException("Please add your product first!"); }

            shopProducts[barCode].Quantity += quantity;
        }

        public static void PrintAvalableInAlphabeticalOrder()
        {
            foreach(var prod in shopProducts.Values.Where(p => p.Quantity > 0))
            {
                Console.WriteLine(prod);
            }
        }

        public static void PrintUnavalableInAlphabeticalOrder()
        {
            foreach (var prod in shopProducts.Values.Where(p => p.Quantity == 0))
            {
                Console.WriteLine(prod);
            }
        }

        public static void PrintDescendingAvalability()
        {
            foreach (var prod in shopProducts.Values.OrderByDescending(p => p.Quantity))
            {
                Console.WriteLine(prod);
            }
        }

        public static double CalculateTotalValue()
        {
            double val = 0;

            foreach(var prod in shopProducts.Values)
            {
                val += prod.Price * prod.Quantity;
            }

            return val;
        }
    }
}
