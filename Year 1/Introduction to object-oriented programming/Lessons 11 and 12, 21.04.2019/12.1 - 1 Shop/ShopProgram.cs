using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1___1_Shop
{
    class ShopProgram
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();
                if (info[0] == "Close") break;

                try
                {
                    switch (info[0])
                    {
                        case "Sell": Shop.SellProduct(info[1], double.Parse(info[2])); break;
                        case "Add": Shop.AddProduct(info[2], info[1], double.Parse(info[3]), double.Parse(info[4])); break;
                        case "Update": Shop.UpdateProduct(info[1], double.Parse(info[2])); break;
                        case "PrintA": Shop.PrintAvalableInAlphabeticalOrder(); break;
                        case "PrintU": Shop.PrintUnavalableInAlphabeticalOrder(); break;
                        case "PrintD": Shop.PrintDescendingAvalability(); break;
                        case "Calculate": Console.WriteLine(Shop.CalculateTotalValue()); break;
                    }
                }
                catch (ArgumentException ex)
                { Console.WriteLine(ex.Message); }
            }
        }
    }
}
