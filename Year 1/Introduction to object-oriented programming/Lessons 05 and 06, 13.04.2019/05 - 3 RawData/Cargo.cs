using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___3_RawData
{
    class Cargo
    {
        private string type;
        private int weight;

        public Cargo(string type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }

        public string Type { get => type; set => type = value; }
        public int Weight { get => weight; set => weight = value; }
    }
}
