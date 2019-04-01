using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOfEmplyee
{
    class DataOfEmplyeeProgram
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong personalId = ulong.Parse(Console.ReadLine());
            uint emplyeeNumber = uint.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}\r\nSecond name: {1}\r\nAge: {2}\r\nGender: {3}\r\nPersonal ID: {4}\r\nUnique Employee Number: {5}", 
                firstName, lastName, age, gender, personalId, emplyeeNumber);
        }
    }
}
