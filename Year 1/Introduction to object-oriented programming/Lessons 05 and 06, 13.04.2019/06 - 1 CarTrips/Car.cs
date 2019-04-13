using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___1_CarTrips
{
    class Car
    {
        private string model;
        private float fuel;
        private float fuelPerKm;
        private int mileage;

        public Car(string model, int fuel, float fuelPerKm)
        {
            this.model = model;
            this.fuel = fuel;
            this.fuelPerKm = fuelPerKm;
            mileage = 0;
        }

        public bool SufficientFuel(int km)
        {
            if (fuel - km * fuelPerKm >= 0) return true;
            return false;
        }

        public void MileageAdd(int km)
        {
            mileage += km;
        }

        public void Print()
        {
            Console.WriteLine($"{model} {fuel:F2} {mileage}");
        }

        public string Model { get => model; set => model = value; }
        public float Fuel { get => fuel; set => fuel = value; }
        public float FuelPerKm { get => fuelPerKm; set => fuelPerKm = value; }
        public int Mileage { get => mileage; private set => mileage = value; }
    }
}
