using System;

class Employee
{
    // Properties for Employee class
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overloading the "==" operator to compare Employee objects based on Id property
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        if (ReferenceEquals(emp1, emp2))
        {
            return true;
        }

        if (emp1 is null || emp2 is null)
        {
            return false;
        }

        return emp1.Id == emp2.Id;
    }

    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create Employee objects
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };
        Employee employee3 = new Employee { Id = 1, FirstName = "Alice", LastName = "Johnson" };

        // Compare employees using overloaded "==" operator
        Console.WriteLine($"employee1 == employee2: {employee1 == employee2}");
        Console.WriteLine($"employee1 == employee3: {employee1 == employee3}");
        Console.ReadLine();

    }
}