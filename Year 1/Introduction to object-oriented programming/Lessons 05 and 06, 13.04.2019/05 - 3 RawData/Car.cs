using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___3_RawData
{
    class Car
    {
        private string carModel;
        private Engine carEngine;
        private Cargo carCargo;
        private Tire[] carTires;

        public Car(Engine carEngine, Cargo carCargo, Tire[] carTires) //does not include carModel, because of task conditions
        {
            this.CarEngine = carEngine;
            this.CarCargo = carCargo;
            this.CarTires = carTires;
        }

        public string CarModel { get => carModel; set => carModel = value; }
        internal Cargo CarCargo { get => carCargo; set => carCargo = value; }
        internal Tire[] CarTires { get => carTires; set => carTires = value; }
        internal Engine CarEngine { get => carEngine; set => carEngine = value; }
    }
}
