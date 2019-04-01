using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int outOfHome = int.Parse(Console.ReadLine());
            int leftFood = int.Parse(Console.ReadLine());
            double foodDayFirst = double.Parse(Console.ReadLine());
            double foodDaySecond = double.Parse(Console.ReadLine());

            double firstCat = outOfHome * foodDayFirst;
            double secondCat = outOfHome * foodDaySecond;
            double totalConsumed = Math.Floor(firstCat + secondCat);

            if (leftFood >= totalConsumed)
            {
                Console.WriteLine("The cats are well fed.");
                Console.WriteLine($"{leftFood - totalConsumed} kilos of food left.");
            }
            else
            {
                Console.WriteLine("The cats are hungry.");
                Console.WriteLine($"{totalConsumed - leftFood} more kilos of food are needed");
            }

            // na tazi imam 100/100 tochki
        }
    }
}
