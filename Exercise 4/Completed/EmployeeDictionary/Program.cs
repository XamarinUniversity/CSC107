using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: create a Dictionary from int to Employee
            Dictionary<int, Employee> EmployeeDictionary = new Dictionary<int, Employee>();

            // TODO: Add an employee with an id of 101 to the dictionary
            EmployeeDictionary.Add(101, new Employee
            {
                Id = 101,
                FirstName = "Jesse",
                LastName = "Liberty"
            });
            // TODO: Add an employee with an id of 102 to the dictionary
            EmployeeDictionary.Add(102, new Employee
            {
                Id = 102,
                FirstName = "George",
                LastName = "Washington"
            });
            // TODO: Add an employee with an id of 103 to the dictionary
            EmployeeDictionary.Add(103, new Employee
            {
                Id = 103,
                FirstName = "Mark",
                LastName = "Smith"
            });

            // TODO: Display the three employees
            Console.WriteLine(EmployeeDictionary[101]);
            Console.WriteLine(EmployeeDictionary[102]);
            Console.WriteLine(EmployeeDictionary[103]);
        }
    }
}
