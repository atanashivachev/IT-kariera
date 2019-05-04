using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_15._07._2017
{
    class Harvester
    {
        private string type;
        private string id;
        
        private double oreOutput;
        private double energyRequirement;

        private sbyte sonicFactor;

        public Harvester(string type, string id, double oreOutput, double energyRequirement) :this(type, id, oreOutput, energyRequirement, 1)
        { }

        public Harvester(string type, string id, double oreOutput, double energyRequirement, sbyte sonicFactor)
        {
            Type = type;
            Id = id;

            if (type == "Hammer") OreOutput = oreOutput * 2;
            else OreOutput = oreOutput;

            SonicFactor = sonicFactor;
            EnergyRequirement = energyRequirement / SonicFactor;
        }

        public string Id { get => id; set => id = value; }
        public double OreOutput
        {
            get { return oreOutput; }
            set
            {
                if (value < 0)
                { throw new ArgumentException("Harvester is not registered, because of it's OreOutput"); }

                oreOutput = value;
            }
        }
        public double EnergyRequirement
        {
            get { return energyRequirement; }
            set
            {
                if (value < 0 || value > 10000)
                { throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement"); }

                energyRequirement = value;
            }
        }
        public sbyte SonicFactor { get => sonicFactor; private set => sonicFactor = value; }
        public string Type { get => type; set => type = value; }
    }
}
