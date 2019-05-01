using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___FreightTransport
{
    class Truck
    {
        private string name;
        private int loadCapacity;
        private List<Freight> freightsList;

        public Truck(string name, int loadCapacity)
        {
            Name = name;
            LoadCapacity = loadCapacity;
            freightsList = new List<Freight>();
        }

        public void LoadFreight(Freight freightToLoad)
        {
            string message = null;

            if (loadCapacity < freightsList.Sum(f => f.Weight) + freightToLoad.Weight)
            { message = $"{name} cannot load {freightToLoad.Name}"; }
            else
            {
                freightsList.Add(freightToLoad);
                message = $"{name} loaded {freightToLoad.Name}";
            }

            Console.WriteLine(message);
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

        public int LoadCapacity
        {
            get { return loadCapacity; }
            set
            {
                if (value < 0)
                { throw new ArgumentException("Load capacity cannot be negative"); }

                loadCapacity = value;
            }
        }

        public List<Freight> FreightsList
        {
            get { return freightsList; }
            private set { freightsList = value; }
        }
    }
}
