using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_STAR___StarWarsEmpire
{
    class Planet
    {
        private string name;
        private int metal;
        private int mineral;

        private List<Building> buildingsList;
        private List<Ship> shipsList;

        public void BuildBuilding(Building toBuild)
        {
            string message = ""; //grammatical mistakes from task desciption are left

            if (Metal < toBuild.Metal) message = $"{Name} have not resource metal to build {toBuild.Name}"; 
            else if (Mineral < toBuild.Mineral) message = $"{Name} have not resource mineral to build {toBuild.Name}";
            else
            {
                metal -= toBuild.Metal;
                mineral -= toBuild.Mineral;
                BuildingsList.Add(toBuild);
                message = $"On {Name} was builded {toBuild.Name}";
            }

            Console.WriteLine(message);
        }

        public void BuildShips(Ship toBuild, int quantity)
        {
            string message = ""; //grammatical mistakes from task desciption are left

            if (Metal < toBuild.Metal * quantity) message = $"{Name} have not resource metal to build a {toBuild.Name} {quantity} units.";
            else if (Mineral < toBuild.Mineral * quantity) message = $"{Name} have not resource mineral to build a {toBuild.Name} {quantity} units.";
            else
            {
                Metal -= toBuild.Metal * quantity;
                Mineral -= toBuild.Mineral * quantity;
                
                for (int i = 0; i < quantity; i++)
                { ShipsList.Add(toBuild); }

                message = $"On {Name} was builded {toBuild.Name} {quantity}";
            }

            Console.WriteLine(message);
        }

        public void Time(int timeValue)
        {
            Metal += BuildingsList.Count() * 100 * timeValue;
            Mineral += BuildingsList.Count() * 100 * timeValue;
        }

        public Planet(string name, int metal, int mineral)
        {
            Name = name;
            Metal = metal;
            Mineral = mineral;

            buildingsList = new List<Building>();
            shipsList = new List<Ship>();
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

        public List<Building> BuildingsList
        {
            get { return buildingsList; }
            private set { buildingsList = value; }
        }

        public List<Ship> ShipsList
        {
            get { return shipsList; }
            private set { shipsList = value; }
        }
    }
}
