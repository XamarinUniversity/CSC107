using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create employeeArray
            Employee[] employeeArray = new Employee[3];

            // TODO: Populate employeeArray with some data
            employeeArray[0] = new Employee { FirstName = "Jesse", LastName = "Liberty" };
            employeeArray[1] = new Employee { FirstName = "George", LastName = "Washington" };
            employeeArray[2] = new Employee { FirstName = "Mark", LastName = "Smith" };

            // TODO: Display employeeArray
            for (int i = 0; i < employeeArray.Length; i++)
            {
                Console.WriteLine(employeeArray[i]);
            }
            //or with a foreach loop
            //foreach (Employee e in employeeArray)
            //{
            //    Console.WriteLine(e);
            //}
        }
    }
}
