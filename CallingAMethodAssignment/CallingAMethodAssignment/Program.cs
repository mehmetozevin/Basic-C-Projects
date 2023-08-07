using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingAMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user what number they want to do the math operations on
            Console.Write("Enter a number for math operations: ");
            int userInput = int.Parse(Console.ReadLine());

            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call each method and display the returned integer
            int resultAdd = mathOps.Add(userInput);
            Console.WriteLine("Result of addition 10 to you number: {resultAdd}");

            int resultSubtract = mathOps.Subtract(userInput);
            Console.WriteLine($"Result of subtraction 5 from your selected number: {resultSubtract}");

            int resultMultiply = mathOps.Multiply(userInput);
            Console.WriteLine($"Result of multiplication with 2: {resultMultiply}");

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press to exit.");
            Console.ReadKey();
        }
    }
}
