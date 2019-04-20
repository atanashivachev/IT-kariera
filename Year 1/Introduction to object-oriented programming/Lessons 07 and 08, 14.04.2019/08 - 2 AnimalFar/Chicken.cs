using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___2_AnimalFar
{
    class Chicken
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value.All(e => e == ' ')) throw new ArgumentException("Name cannot be empty.");
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if(value < 0 || value > 16) throw new ArgumentException("Age should be between 0 and 15.");
                age = value;
            }
        }

        public override string ToString()
        {
            return $"Chicken {Name} (age {Age}) can produce {productPerDay()} eggs per day.";
        }

        public double productPerDay()
        {
            return CalculateProductPerDay();
        }

        private double CalculateProductPerDay()
        {
            //code taken from: https://github.com/hammer4/SoftUni/blob/master/C%23%20Basics%20OOP/4.%20Encapsulation%20Exercises/03.%20Animal%20Farm/Models/Chicken.cs
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}
