using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___3_RawData
{
    class RawDataProgram
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            for(int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();

                Tire[] tires = new Tire[4];
                for(int j = 0; j < 7; j += 2)
                {
                    tires[j / 2] = new Tire(int.Parse(info[6 + j]), double.Parse(info[5 + j]));
                }

                Car tempCar  = new Car(new Engine(int.Parse(info[1]), int.Parse(info[2])), 
                                        new Cargo(info[4], int.Parse(info[3])), 
                                        tires);

                tempCar.CarModel = info[0];

                cars.Add(tempCar);
            }

            string type = Console.ReadLine();
            foreach(var car in cars)
            {
                if(type == "fragile" && car.CarTires.Select(c => c.Pressure).Average() < 1 ||
                    type == "flamable" && car.CarEngine.Power > 250)
                { Console.WriteLine(car.CarModel); }
            }
        }
    }
}
