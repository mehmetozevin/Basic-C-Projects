using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Define an abstract class called Person
    abstract class Person
    {
        // Properties to store first name and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method to be implemented by derived classes
        public abstract void SayName();
    }

    // Create a class called Employee that inherits from Person
    class Employee : Person
    {
        // Implement the SayName() method from the Person class
        public override void SayName()
        {
            Console.WriteLine($"Employee's Name: {FirstName} {LastName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee employee = new Employee();

            // Set first name and last name properties
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Call the SayName() method on the Employee object
            employee.SayName();
        }
    }
