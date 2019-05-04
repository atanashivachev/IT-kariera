using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_15._07._2017
{
    class Provider
    {
        private string type;
        private string id;

        private double energyOutput;

        public Provider(string type, string id, double energyOutput)
        {
            Type = type;
            Id = id;

            EnergyOutput = energyOutput;
            if (type == "Pressure") EnergyOutput += energyOutput * 0.5;
        }

        public string Id { get => id; set => id = value; }
        public double EnergyOutput
        {
            get { return energyOutput; }
            set
            {
                if (value < 0 || value > 10000)
                { throw new ArgumentException("Provider is not registered, because of it's EnergyOutput"); }

                energyOutput = value;
            }
        }
        public string Type { get => type; set => type = value; }
    }
}
