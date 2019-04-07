using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___3_ListOfEmployees
{
    class ListOfEmployeesProgram
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Employee>> employees = new Dictionary<string, List<Employee>>();

            for(int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();

                Employee emp = new Employee { Age = -1, Email = "n/a" };

                emp.Name = info[0];
                emp.Salary = double.Parse(info[1]);
                emp.Job = info[2];
                emp.Department = info[3];

                if(info.Length == 5)
                {
                    if (info[4].Contains('@')) emp.Email = info[4];
                    else emp.Age = sbyte.Parse(info[4]);
                }
                else if (info.Length == 6)
                {
                    emp.Email = info[4]; emp.Age = sbyte.Parse(info[5]);
                }

                if (!employees.ContainsKey(info[3])) employees.Add(info[3], new List<Employee>());

                employees[info[3]].Add(emp);
            }

            Dictionary<string, List<Employee>> highestAvgSal = employees.OrderByDescending(pair => pair.Value.Select(p => p.Salary).Average())
                                                                        .Take(1).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Highest Average Salary: {highestAvgSal.First().Key}");
            foreach(var emp in highestAvgSal.Values.First().OrderByDescending(p => p.Salary))
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
