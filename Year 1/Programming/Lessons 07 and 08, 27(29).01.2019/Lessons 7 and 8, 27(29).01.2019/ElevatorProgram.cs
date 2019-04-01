using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class ElevatorProgram
    {
        static void Main(string[] args)
        {
            float people = float.Parse(Console.ReadLine());
            float capacity = float.Parse(Console.ReadLine());
            uint trips = Convert.ToUInt32(Math.Ceiling(people/capacity));
            Console.WriteLine(trips);
        }
    }
}
