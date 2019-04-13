using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___3_CarSales
{
    class CarSalesmanProgram
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();

            for(int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();

                if (info.Length == 4)
                { engines.Add(info[0], new Engine(info[0], int.Parse(info[1]), int.Parse(info[2]), info[3])); }
                else if (info.Length == 2)
                { engines.Add(info[0], new Engine(info[0], int.Parse(info[1]))); }
                else
                {
                    try
                    { engines.Add(info[0], new Engine(info[0], int.Parse(info[1]), int.Parse(info[2]))); }
                    catch (Exception)
                    { engines.Add(info[0], new Engine(info[0], int.Parse(info[1]), info[2])); }
                }
            }

            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                string[] info = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();

                if (info.Length == 4)
                { cars.Add(new Car(info[0], engines[info[1]], int.Parse(info[2]), info[3])); }
                else if (info.Length == 2)
                { cars.Add(new Car(info[0], engines[info[1]])); }
                else
                {
                    try
                    { cars.Add(new Car(info[0], engines[info[1]], int.Parse(info[2]))); }
                    catch (Exception)
                    { cars.Add(new Car(info[0], engines[info[1]], info[2])); }
                }
            }

            foreach(var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
