using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___1_CarTrips
{
    class CarTripsProgram
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for(int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();
                cars.Add(info[0], new Car(info[0], int.Parse(info[1]), float.Parse(info[2])));
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                if (command[0] == "End") break;

                if (cars.ContainsKey(command[1]))
                {
                    if (cars[command[1]].SufficientFuel(int.Parse(command[2])))
                    {
                        cars[command[1]].Fuel -= cars[command[1]].FuelPerKm * int.Parse(command[2]);
                        cars[command[1]].MileageAdd(int.Parse(command[2]));
                    }
                    else Console.WriteLine("Insufficient fuel for the drive");
                }
                else Console.WriteLine("Car doesn't exist!");
            }

            foreach(var car in cars.Values)
            {
                car.Print();
            }
        }
    }
}
