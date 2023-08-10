using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Print the current date and time
                DateTime currentDateTime = DateTime.Now;
                Console.WriteLine($"Current Date and Time: {currentDateTime}");

                // Prompt the user for a number
                Console.Write("Enter a number of hours: ");
                int hoursToAdd = Convert.ToInt32(Console.ReadLine());

                // Calculate the future date and time
                DateTime futureDateTime = currentDateTime.AddHours(hoursToAdd);
                Console.WriteLine($"Exact time in {hoursToAdd} hours: {futureDateTime}");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
