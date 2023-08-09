using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Alice", LastName = "Johnson" },
            new Employee { Id = 3, FirstName = "Bob", LastName = "Brown" },
            new Employee { Id = 4, FirstName = "Joe", LastName = "Doe" },
            new Employee { Id = 5, FirstName = "Eva", LastName = "Williams" },
            new Employee { Id = 6, FirstName = "Tom", LastName = "Davis" },
            new Employee { Id = 7, FirstName = "Linda", LastName = "Miller" },
            new Employee { Id = 8, FirstName = "Joe", LastName = "Anderson" },
            new Employee { Id = 9, FirstName = "John", LastName = "Martinez" },
            new Employee { Id = 10, FirstName = "Sara", LastName = "Garcia" }
        };

            // Create a new list of employees with the first name "Joe" using foreach loop
            List<Employee> joesUsingForeach = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joesUsingForeach.Add(employee);
                }
            }

            // Create a new list of employees with the first name "Joe" using lambda expression
            List<Employee> joesUsingLambda = employees.Where(employee => employee.FirstName == "Joe").ToList();

            // Create a list of employees with an Id greater than 5 using lambda expression
            List<Employee> employeesWithIdGreaterThan5 = employees.Where(employee => employee.Id > 5).ToList();

            // Print the lists
            Console.WriteLine("Employees with first name 'Joe' (using foreach loop):");
            foreach (Employee employee in joesUsingForeach)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }

            Console.WriteLine("\nEmployees with first name 'Joe' (using lambda expression):");
            foreach (Employee employee in joesUsingLambda)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }

            Console.WriteLine("\nEmployees with Id greater than 5 (using lambda expression):");
            foreach (Employee employee in employeesWithIdGreaterThan5)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }
        }
    }
}




