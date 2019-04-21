using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_PizzaCals
{
    class Pizza
    {
        private string name;
        private Dough pizzaDough;
        private Topping[] pizzaToppings;

        public double GetCalories()
        {
            return pizzaDough.Calories + pizzaToppings.Select(t => t.Calories).Sum();
        }

        public Pizza(string name, int toppings)
        {
            Name = name;

            if(toppings > 10)
            { throw new ArgumentException("Number of toppings should be in range [0..10]."); }

            PizzaToppings = new Topping[toppings];
        }

        public override string ToString()
        {
            return $"{Name} - {GetCalories():F2} Calories.";
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length == 0 || value.Length > 15)
                { throw new ArgumentException("Pizza name should be between 1 and 15 symbols."); }

                name = value;
            }
        }
        internal Dough PizzaDough { get => pizzaDough; set => pizzaDough = value; }
        internal Topping[] PizzaToppings { get => pizzaToppings; set => pizzaToppings = value; }
    }
}
