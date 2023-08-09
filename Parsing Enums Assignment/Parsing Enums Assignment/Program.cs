using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{

    class Program
    {
        // Enum to represent the days of the week
        enum DaysOfWeek
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter the current day of the week
                Console.Write("Enter the current day of the week: ");
                string userInput = Console.ReadLine();

                // Convert user input to enum value (case-insensitive)
                DaysOfWeek currentDay;
                if (Enum.TryParse(userInput, true, out currentDay))
                {
                    // Print the entered day
                    Console.WriteLine($"You entered: {currentDay}");
                }
                else
                {
                    // If user input doesn't match any enum value, display an error message
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
