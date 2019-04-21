using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_PizzaCals
{
    class Dough
    {
        private string type;
        private string cooked;
        private int weight;
        private double calories;

        public Dough(string type, string cooked, int weight)
        {
            Type = type;
            Cooked = cooked;
            Weight = weight;

            double modificator = 0;

            switch (type)
            {
                case "white": modificator = 1.5; break;
                case "wholegrain": modificator = 1.0; break;
            }

            switch (cooked)
            {
                case "crispy": modificator *= 0.9; break;
                case "chewy": modificator *= 1.1; break;
                case "homemade": modificator *= 1.0; break;
            }

            calories = 2 * weight * modificator;
        }

        public string Type
        {
            set
            {
                if (value != "white" && value != "wholegrain")
                { throw new ArgumentException("Invalid type of dough"); }

                type = value;
            }
        }

        public string Cooked
        {
            set
            {
                if (value != "crispy" && value != "chewy" && value != "homemade")
                { throw new ArgumentException("Invalid type of dough"); }

                cooked = value;
            }
        }

        public int Weight
        {
            set
            {
                if (value < 1 || value > 200)
                { throw new ArgumentException("Dough weight should be in the range [1..200]."); }

                weight = value;
            }
        }

        public double Calories { get => calories; private set => calories = value; }
        
    }
}
