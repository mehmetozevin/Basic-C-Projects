using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 123
            };

            // Call the superclass method SayName() on the Employee object
            employee.SayName();

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
