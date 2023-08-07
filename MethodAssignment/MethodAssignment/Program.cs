using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user to input two numbers
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number (optional): ");
            string inputNum2 = Console.ReadLine();
            int num2;

            // Convert the second input to integer if provided, otherwise default to 0
            if (string.IsNullOrWhiteSpace(inputNum2))
            {
                num2 = 0;
            }
            else
            {
                num2 = int.Parse(inputNum2);
            }

            // Call the method in the class and display the result
            int result = mathOps.PerformOperation(num1, num2);
            Console.WriteLine($"Result of the operation: {result}");

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
