using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_PizzaCals
{
    class Topping
    {
        private string type;
        private int weight;
        private double calories;

        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;

            double mod = 0;
            switch (type)
            {
                case "meat": mod = 1.2; break;
                case "veggies": mod = 0.8; break;
                case "cheese": mod = 1.1; break;
                case "sauce": mod = 0.9; break;
            }

            calories = 2 * weight * mod;
        }

        public string Type
        {
            set
            {
                if(value != "meat" && value != "veggies" && value != "cheese" && value != "sauce")
                { throw new ArgumentException($"Cannot place {value} on top of your pizza"); }

                type = value;
            }
        }

        public int Weight
        {
            set
            {
                if (value < 1 || value > 50)
                { throw new ArgumentException($"{type} weight should be in the range[1..50]."); }

                weight = value;
            }
        }

        public double Calories
        {
            get { return calories; }
        }
    }
}
