using System;
using System.Collections.Generic;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a list of integers
                List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

                // Ask the user for a number to divide each number in the list by
                Console.Write("\"10,20,30,40,50\" Enter a number to divide each number in the list: ");
                string userInput = Console.ReadLine();

                // Parse the user input to get the divisor
                int divisor = int.Parse(userInput);

                // Loop to divide each integer in the list by the user-provided divisor and display the result
                foreach (int number in numbers)
                {
                    int result = number / divisor;
                    Console.WriteLine($"{number} / {divisor} = {result}");
                }
            }
            catch (DivideByZeroException ex)
            {
                // Catch the DivideByZeroException if the user enters zero as the divisor
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine("Error message: " + ex.Message);
            }
            catch (FormatException ex)
            {
                // Catch the FormatException if the user enters a non-integer input
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
                Console.WriteLine("Error message: " + ex.Message);
            }
            finally
            {
                // Display a message to indicate that the program has emerged from the try/catch block
                Console.WriteLine("The program has continued after the try/catch block.");
            }

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}