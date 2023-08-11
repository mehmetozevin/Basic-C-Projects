using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a const variable and assign a value.
            const int MyConstant = 42;

            // Create a variable using the "var" keyword.
            var message = "Hello there";

            // Chain two constructors in a simple example.
            Book book1 = new Book("Title Only"); // Calls the constructor with one parameter.
            Console.WriteLine(book1.GetInfo()); // Output: Title: Title Only, Pages: 0

            Book book2 = new Book("Introduction to Programming", 300); // Calls the constructor with two parameters.
            Console.WriteLine(book2.GetInfo()); // Output: Title: Introduction to Programming, Pages: 300
        }
    }

    // Simple Book class with constructors and methods.
    class Book
    {
        private string title;
        private int pages;

        // Constructor with a single parameter.
        public Book(string t)
        {
            title = t;
            pages = 0;
        }

        // Constructor with two parameters.
        public Book(string t, int p)
        {
            title = t;
            pages = p;
        }

        // Method to get book information.
        public string GetInfo()
        {
            return $"Title: {title}, Pages: {pages}";
        }
    }
}
