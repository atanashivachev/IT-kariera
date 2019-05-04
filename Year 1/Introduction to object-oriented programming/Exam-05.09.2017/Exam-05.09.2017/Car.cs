using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_05._09._2017
{
    class Car
    {
        private int hp;
        private double fuelAmount;
        private Tyre carTire;

        public Car(int hp, double fuelAmount, Tyre carTire)
        {
            Hp = hp;
            FuelAmount = fuelAmount;
            CarTire = carTire;
        }

        public void Refuel(double amount)
        {
            if (amount + fuelAmount > 160) FuelAmount = 160;
            else FuelAmount += amount;
        }

        public void ReduceFuel(int trackLength, double fuelConcumptionPerKm)
        {
            FuelAmount -= trackLength * fuelConcumptionPerKm;

            if (FuelAmount < 0)
            { throw new ArgumentException("Out of fuel"); }
        }

        public int Hp { get => hp; set => hp = value; }

        public double FuelAmount
        {
            get { return fuelAmount; }
            private set { fuelAmount = value; }
        }

        public Tyre CarTire { get => carTire; set => carTire = value; }
    }
}
