using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user for their age.
                Console.Write("Please enter your age: ");
                int age = int.Parse(Console.ReadLine());

                // Check if age is a valid positive number.
                if (age <= 0)
                {
                    throw new ArgumentOutOfRangeException("age", "Age must be a positive number.");
                }

                // Calculate the birth year and display it.
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;
                Console.WriteLine($"You were born in the year {birthYear}.");
            }
            catch (FormatException)
            {
                // Handle format exception (invalid input).
                Console.WriteLine("Invalid input. Please enter a valid number for age.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Handle ArgumentOutOfRangeException (negative or zero age).
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                // Handle any other exceptions.
                Console.WriteLine("An error occurred.");
            }
            Console.ReadLine();

        }

    }
}

