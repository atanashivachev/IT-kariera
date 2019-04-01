using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int doctors = 7;

            for (int i = 1; i <= period; i++)
            {
                int patient = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && untreatedPatients > treatedPatients) doctors++;
                if (doctors >= patient) treatedPatients += patient;
                else { treatedPatients += doctors; untreatedPatients += patient - doctors; }
            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
