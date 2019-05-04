using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_05._09._2017
{
    static class RaceTower
    {
        public static string Weather { get; private set; }
        public static int CurrentLap { get; private set; }
        public static int LapsNumber { get; private set; }
        public static int TrackLength { get; private set; }

        private static Dictionary<string, Driver> drivers = new Dictionary<string, Driver>();
        private static Dictionary<Driver, string> dnf = new Dictionary<Driver, string>();

        public static void SetTrackInfo(int lapsNumber, int trackLength)
        {
            LapsNumber = lapsNumber;
            TrackLength = trackLength;
        }
        public static void RegisterDriver(List<string> commandArgs)
        {
            try
            {
                if (commandArgs.Count == 7)
                { drivers.Add(commandArgs[2], new Driver(commandArgs[1] == "Aggressive", commandArgs[2], int.Parse(commandArgs[3]), double.Parse(commandArgs[4]), commandArgs[5], double.Parse(commandArgs[6]))); }
                else
                { drivers.Add(commandArgs[2], new Driver(commandArgs[1] == "Aggressive", commandArgs[2], int.Parse(commandArgs[3]), double.Parse(commandArgs[4]), commandArgs[5], double.Parse(commandArgs[6]), double.Parse(commandArgs[7]))); }
            }
            catch (ArgumentException) { }
        }

        public static void DriverBoxes(List<string> commandArgs)
        {
            drivers[commandArgs[2]].TotalTime += 20;

            if (commandArgs[1] == "Refuel")
            {
                drivers[commandArgs[2]].PersonnalCar.Refuel(double.Parse(commandArgs[3]));
            }
            else if (commandArgs.Count() == 5)
            {
                drivers[commandArgs[2]].PersonnalCar.CarTire = new Tyre("Hard", double.Parse(commandArgs[4]), -1);
            }
            else
            {
                drivers[commandArgs[2]].PersonnalCar.CarTire = new Tyre("Ultrasoft", double.Parse(commandArgs[4]), double.Parse(commandArgs[5]));
            }
        }

        public static void CompleteLaps(List<string> commandArgs)
        {
            int numberOfLaps = int.Parse(commandArgs[1]);

            if (numberOfLaps > LapsNumber - CurrentLap)
            { throw new ArgumentException($"There is no time! On lap {CurrentLap}"); }

            CurrentLap += numberOfLaps;

            drivers = drivers.OrderBy(d => d.Value.TotalTime).ToDictionary(x => x.Key, x => x.Value);
            for (int lap = 0; lap < numberOfLaps; lap++)
            {
                foreach (var currDriver in drivers.Values)
                { currDriver.CalcSpeed(); }

                for (int i = 0; i < drivers.Count(); i++)
                {
                    var currDriver = drivers.Values.ElementAt(i);
                    try
                    {
                        if (i < drivers.Count - 1 && !currDriver.IsOvertaken)
                        {
                            Driver.Overtake(currDriver, drivers.Values.ElementAt(i + 1), Weather, lap);
                        }

                        currDriver.PersonnalCar.CarTire.Degrade();
                        currDriver.PersonnalCar.ReduceFuel(TrackLength, currDriver.FuelConsumptionPerKm);
                        currDriver.TotalTime += 60 / (TrackLength / currDriver.Speed);
                    }
                    catch (ArgumentException ex)
                    {
                        dnf.Add(currDriver, ex.Message);
                        drivers.Remove(currDriver.Name);
                        i--;
                    }
                }
                drivers.Values.Where(d => d.IsOvertaken).Select(d => d.IsOvertaken = false);
            }
        }

        public static void Leaderboard()
        {
            Console.WriteLine($"Lap {CurrentLap}/{LapsNumber}");

            int position = 1;
            foreach(var currDriver in drivers.Values.OrderBy(x => x.TotalTime))
            {
                Console.WriteLine($"{position} {currDriver.Name} {currDriver.TotalTime:F3}");
                position++;
            }

            foreach (var currDriver in dnf.Reverse())
            {
                Console.WriteLine($"{position} {currDriver.Key.Name} {currDriver.Value}");
                position++;
            }
        }

        public static void Winner()
        {
            var winner = drivers.Values.OrderBy(d => d.TotalTime).First();
            Console.WriteLine($"{winner.Name} wins the race for {winner.TotalTime:F3} seconds.");
        }

        public static void ChangeWeather(List<string> commandArgs)
        {
            Weather = commandArgs[1];
        }

    }
}
