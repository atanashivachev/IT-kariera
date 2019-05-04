using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_05._09._2017
{
    class Driver
    {
        private string name;
        private bool isAggressive;

        public bool IsOvertaken { get; set; }

        private double totalTime;
        private Car personnalCar;
        private double fuelConsumptionPerKm;
        private double speed;

        public static void Overtake(Driver currDriver, Driver driverToOvertake, string weather, int currentLap)
        {
            double overtakeInterval = currDriver.TotalTime - driverToOvertake.TotalTime;

            if (currDriver.IsAggressive && currDriver.PersonnalCar.CarTire.Grip > -1 && overtakeInterval <= 3 && overtakeInterval >= 0)
            {
                if (weather == "Foggy") throw new ArgumentException("Crashed");
                DoTheOvertake(currDriver, driverToOvertake, overtakeInterval, currentLap);
            }
            else if (!currDriver.IsAggressive && currDriver.PersonnalCar.CarTire.Grip == -1 && overtakeInterval <= 3 && overtakeInterval >= 0)
            {
                if (weather == "Rainy") throw new ArgumentException("Crashed");
                DoTheOvertake(currDriver, driverToOvertake, overtakeInterval, currentLap);
            }
            else if (overtakeInterval <= 2 && overtakeInterval >= 0)
            { DoTheOvertake(currDriver, driverToOvertake, overtakeInterval, currentLap); }
        }

        private static void DoTheOvertake(Driver currDriver, Driver driverToOvertake, double overtakeInterval, int currentLap)
        {
            if (currDriver.TotalTime > 0 && driverToOvertake.TotalTime > 0)
            {
                currDriver.TotalTime -= overtakeInterval;
                driverToOvertake.TotalTime += overtakeInterval;
                driverToOvertake.IsOvertaken = true;
                Console.WriteLine($"{currDriver.Name} has overtaken {driverToOvertake.Name} on lap {currentLap}");
            } 
        }

        public Driver(bool isAggressive, string name, int hp, double fuelAmount, string tyreName, double tyreHardness) : this (isAggressive, name, hp, fuelAmount, tyreName, tyreHardness, -1)
        { }

        public Driver(bool isAggressive, string name, int hp, double fuelAmount, string tyreName, double tyreHardness, double grip)
        {
            IsAggressive = isAggressive;
            CalcFuelConsumption();
            Name = name;
            PersonnalCar = new Car(hp, fuelAmount, new Tyre(tyreName, tyreHardness, grip));
            CalcSpeed();
        }

        private void CalcFuelConsumption()
        {
            if (IsAggressive) FuelConsumptionPerKm = 2.7;
            else FuelConsumptionPerKm = 1.5;
        }

        public void CalcSpeed()
        {
            if (isAggressive) speed = ((PersonnalCar.Hp + PersonnalCar.CarTire.Degradation) / PersonnalCar.FuelAmount) * 1.3;
            else speed = (PersonnalCar.Hp + PersonnalCar.CarTire.Degradation) / PersonnalCar.FuelAmount;
        }

        public string Name { get => name; set => name = value; }
        public double TotalTime { get => totalTime; set => totalTime = value; }
        public double FuelConsumptionPerKm { get => fuelConsumptionPerKm; private set => fuelConsumptionPerKm = value; }

        public double Speed
        {
            get { return speed; }
            private set { speed = value; }
        }

        public bool IsAggressive { get => isAggressive; set => isAggressive = value; }
        internal Car PersonnalCar { get => personnalCar; private set => personnalCar = value; }
    }
}
