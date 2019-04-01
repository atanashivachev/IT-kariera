using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double stay = double.Parse(Console.ReadLine());

            double priceS = 0;
            double priceA = 0;

            switch (month)
            {
                case "May":
                case "October": priceS = 50; priceA = 65; break;
                case "June":
                case "September": priceS = 75.2; priceA = 68.7; break;
                case "July":
                case "August": priceS = 76; priceA = 77; break;
            }

            if (stay > 14)
            {
                priceA -= priceA * 0.1;
                if (month == "May" || month == "October") priceS -= priceS * 0.3;
                else if (month == "June" || month == "September") priceS -= priceS * 0.2;
            }
            else if (stay > 7 && month == "May" || month == "October") priceS -= priceS * 0.05;

            Console.WriteLine($"Apartment: {priceA * stay:F2} lv.");
            Console.WriteLine($"Studio: {priceS * stay:F2} lv.");
        }
    }
}
