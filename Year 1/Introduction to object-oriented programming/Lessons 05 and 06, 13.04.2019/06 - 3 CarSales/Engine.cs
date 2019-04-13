using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___3_CarSales
{
    class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public override string ToString()
        {
            return $" {model}:\r\n   Power: {power}\r\n   Displacement: {NADispl()}\r\n   Efficiency: {efficiency}";
        }

        private string NADispl()
        {
            if (displacement == -1) return "n/a";
            return displacement.ToString();
        }

        public Engine(string model, int power) : this(model, power, -1, "n/a")
        { }

        public Engine(string model, int power, int displacement) : this(model, power, displacement, "n/a")
        { }

        public Engine(string model, int power, string efficiency) : this(model, power, -1, efficiency)
        { }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public int Power { get => power; set => power = value; }
        public string Model { get => model; set => model = value; }
        public int Displacement { get => displacement; set => displacement = value; }
        public string Efficiency { get => efficiency; set => efficiency = value; }
    }
}
