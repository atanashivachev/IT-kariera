using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___StarWars_From2To4
{
    class Building
    {
        private string name;
        private int metal;
        private int mineral;

        public Building(string name): this (name, 0, 0)
        { }

        public Building(string name, int metal, int mineral)
        {
            Name = name;
            Metal = metal;
            Mineral = mineral;
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

        public int Metal
        {
            get { return metal; }
            set
            {
                if (value < 0)
                { throw new ArgumentException("Metal cannot be negative"); }

                metal = value;
            }
        }

        public int Mineral
        {
            get { return mineral; }
            set
            {
                if (value < 0)
                { throw new ArgumentException("Mineral cannot be negative"); }

                mineral = value;
            }
        }
    }
}
