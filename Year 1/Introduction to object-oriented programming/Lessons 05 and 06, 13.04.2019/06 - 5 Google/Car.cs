using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___5_Google
{
    class Car
    {
        private string model;
        private int speed;

        public Car() { }

        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public override string ToString()
        {
            return $"{Model} {Speed}";
        }

        public int Speed { get => speed; set => speed = value; }
        public string Model { get => model; set => model = value; }
    }
}
