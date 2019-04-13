using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___3_RawData
{
    class Tire
    {
        private int age;
        private double pressure;

        public Tire(int age, double pressure)
        {
            this.age = age;
            this.pressure = pressure;
        }

        public int Age { get => age; set => age = value; }
        public double Pressure { get => pressure; set => pressure = value; }
    }
}
