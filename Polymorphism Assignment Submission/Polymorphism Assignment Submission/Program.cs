using System;

// Define a class called Person
class Person
{
    // Properties to store first name and last name
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Method to display the person's full name
    public void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

// Define a class called Employee that inherits from Person
class Employee : Person, IQuittable
{
    // Property to store employee ID
    public int Id { get; set; }

    // Implement the Quit() method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"Employee {FirstName} {LastName} has quit.");
    }
}

// Define an interface called IQuittable
interface IQuittable
{
    void Quit();
}

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

        // Call the SayName() method on the Employee object
        employee.SayName();

        // Use polymorphism to create an object of type IQuittable
        IQuittable quittableEmployee = employee;

        // Call the Quit() method using the IQuittable reference
        quittableEmployee.Quit();
        Console.ReadLine();
    }

    
}
