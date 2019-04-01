using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            int stayTime = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            double price = 0;

            switch (roomType)
            {
                case "apartment": price = stayTime * 70; break;
                case "president apartment": price = stayTime * 125; break;
            }

            if (stayTime < 10)
            {
                switch (roomType)
                {
                    case "apartment": price -= price * 0.3; break;
                    case "president apartment": price -= price * 0.1; break;
                }
            }
            else if (stayTime <= 15)
            {
                switch (roomType)
                {
                    case "apartment": price -= price * 0.35; break;
                    case "president apartment": price -= price * 0.15; break;
                }
            }
            else
            {
                switch (roomType)
                {
                    case "apartment": price -= price * 0.5; break;
                    case "president apartment": price -= price * 0.2; break;
                }
            }

            Console.WriteLine($"{price:F2}");

            // na tazi zadacha imam 100/100 tochki
        }
    }
}
