using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: define a List of employee objects
            List<Employee> employeeList = new List<Employee>();

            // TODO: populate some employees into your list
            employeeList.Add(new Employee { FirstName = "Jesse", LastName = "Liberty" });
            employeeList.Add(new Employee { FirstName = "George", LastName = "Washington" });
            employeeList.Add(new Employee { FirstName = "Mark", LastName = "Smith" });

            // TODO: display the list
            for (int i = 0; i < employeeList.Count; i++)
            {
                Console.WriteLine(employeeList[i]);
            }
            //or with foreach loop
            //foreach (Employee e in employeeList)
            //{
            //    Console.WriteLine(e);
            //}
        }
    }
}
