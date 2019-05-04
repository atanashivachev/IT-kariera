using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_05._09._2017
{
    class Tyre
    {
        private string name;
        private double grip;

        private double hardness;
        private double degradation;

        public Tyre(string name, double hardness, double grip)
        {
            Name = name;
            Hardness = hardness;
            Grip = grip;
            Degradation = 100;
        }

        public void Degrade()
        {
            if (grip > -1)
            {
                Degradation -= Hardness + Grip;

                if (degradation < 30)
                { throw new ArgumentException("Blown Tyre"); }
            }
            else
            {
                Degradation -= Hardness;

                if (degradation < 0)
                { throw new ArgumentException("Blown Tyre"); }
            }
        }

        public string Name { get => name; set => name = value; }
        public double Hardness { get => hardness; set => hardness = value; }

        public double Degradation
        {
            get { return degradation; }
            private set { degradation = value; }
        }

        public double Grip { get => grip; set => grip = value; }
    }
}
