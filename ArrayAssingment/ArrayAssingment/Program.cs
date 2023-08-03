using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssingment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of strings
            string[] stringArray = { "Apple", "Banana", "Cherry", "Orange", "Fig" };

            // Ask the user to select an index
            Console.Write("Enter a number (0 to 4) to display a fruit: ");
            int selectedNumber = int.Parse(Console.ReadLine());

            // Check if the index is within the valid range
            if (selectedNumber >= 0 && selectedNumber < stringArray.Length)
            {
                // Display the string at the selected index
                string selectedString = stringArray[selectedNumber];
                Console.WriteLine($"String at index {selectedNumber} is: {selectedString}");
            }
            else
            {
                Console.WriteLine("Invalid number! You should have selected a number between 0 and 4.");
            }

            // Creating an array of integers
            int[] integerArray = { 10, 20, 30, 40, 50 };

            // Asking the user to select an index
            Console.Write("Enter an index (0 to 4) to display a number: ");
            int index = int.Parse(Console.ReadLine());

            // Check if the index is within the valid range
            if (index >= 0 && index < integerArray.Length)
            {
                // Display the integer at the selected index
                int selectedInteger = integerArray[index];
                Console.WriteLine($"Integer at index {index}: {selectedInteger}");
            }
            else
            {
                Console.WriteLine("Invalid index! You should have selected a number between 0 and 4.");
            }

            List<string> strList = new List<string> { "Gokhan", "Baris", "Tolga", "Gokhan", "Sezgin" };


            Console.Write("Enter a number (0 to 4) to display the content at the index in a LIST: ");
            int selectedNList = int.Parse(Console.ReadLine());

            if (selectedNList >= 0 && selectedNList < strList.Count)
            {
                // Display the content at the selected index
                string selectedName = strList[index];
                Console.WriteLine($"Content at index {selectedNList}: {selectedName}");
            }
            else
            {
                Console.WriteLine("Invalid Number! Pick a number between 0 and 4.");
            }

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
