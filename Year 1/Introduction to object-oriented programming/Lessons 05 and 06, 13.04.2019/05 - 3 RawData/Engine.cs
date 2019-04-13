using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___3_RawData
{
    class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            this.speed = speed;
            this.power = power;
        }

        public int Speed { get => speed; set => speed = value; }
        public int Power { get => power; set => power = value; }
    }
}
