using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___3_CarSales
{
    class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public override string ToString()
        {
            return $"{model}:\r\n {engine.ToString()}\r\n Weight: {NAweight()}\r\n Color: {color}";
        }

        private string NAweight()
        {
            if (weight == -1) return "n/a";
            return weight.ToString();
        }

        public Car(string model, Engine engine) : this(model, engine, -1, "n/a")
        { }

        public Car(string model, Engine engine, int weight) : this(model, engine, weight, "n/a")
        { }

        public Car(string model, Engine engine, string color) : this(model, engine, -1, color)
        { }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public string Model { get => model; set => model = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }
        internal Engine Engine { get => engine; set => engine = value; }
    }
}
