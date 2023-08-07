using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathCalculator class
            MathCalculator calculator = new MathCalculator();

            // Ask the user to enter a number
            Console.Write("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());

            // Call the method on the entered number
            calculator.DivideByTwo(userInput);

            // Using method with output parameters
            int num1 = 10, num2 = 5;
            calculator.CalculateSumAndDifference(num1, num2, out int sum, out int difference);
            Console.WriteLine($"Sum of {num1} and {num2}: {sum}");
            Console.WriteLine($"Difference of {num1} and {num2}: {difference}");

            // Using overloaded method with double parameters
            double doubleNum1 = 7.5, doubleNum2 = 3.2;
            calculator.CalculateSumAndDifference(doubleNum1, doubleNum2, out double doubleSum, out double doubleDifference);
            Console.WriteLine($"Sum of {doubleNum1} and {doubleNum2}: {doubleSum}");
            Console.WriteLine($"Difference of {doubleNum1} and {doubleNum2}: {doubleDifference}");

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
