using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___FreightTransport
{
    class Freight
    {
        private string name;
        private int weight;

        public Freight(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                { throw new ArgumentException("Name cannot be empty string"); }

                name = value;
            }
        }

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value < 0)
                { throw new ArgumentException("Weight cannot be negative"); }

                weight = value;
            }
        }
    }
}
