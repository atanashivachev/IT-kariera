using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___5_Google
{
    class Pokemon
    {
        private string name;
        private string element;

        public Pokemon(string name, string element)
        {
            this.name = name;
            this.element = element;
        }

        public override string ToString()
        {
            return $"{name} {element}";
        }

        public string Element { get => element; set => element = value; }
        public string Name { get => name; set => name = value; }
    }
}
