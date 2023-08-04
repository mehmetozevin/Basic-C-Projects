using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASSIGNMENT 1
            //// Create a one-dimensional array of strings
            //string[] stringArray = new string[5];

            //// Ask the user to input some text
            //Console.Write("Enter some text to be assigned each string in the Array: ");
            //string userInput = Console.ReadLine();

            //// Loop to append user's input to each string in the array
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    stringArray[i] = stringArray[i] + userInput;
            //}

            //// Loop to print off each string in the array
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    Console.WriteLine($"String {i + 1}: {stringArray[i]}");
            //}

            //// Wait for the user to press a key before closing the console window
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            ////ASSIGNMENT 2

            //// Create a one-dimensional array of strings
            //string[] stringArray = new string[5];

            //// Ask the user to input some text
            //Console.Write("Enter some text: ");
            //string userInput = Console.ReadLine();

            //// Loop to append user's input to each string in the array
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    stringArray[i] = stringArray[i] + userInput;
            //}

            //// Loop to print off each string in the array
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    Console.WriteLine($"String {i + 1}: {stringArray[i]}");
            //}

            //// An infinite loop to demonstrate the issue (remove this loop later)
            ////int counter = 0;
            ////while (true)
            ////{
            ////    Console.WriteLine($"This is an infinite loop! Iteration: {counter}");
            ////    counter++;
            ////}

            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    Console.WriteLine($"String {i + 1}: {stringArray[i]}");
            //}


            //// Wait for the user to press a key before closing the console window
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            ////ASSIGNMENT 3

            //// Create a one-dimensional array of strings
            //string[] stringArray = new string[5];

            //// Ask the user to input some text
            //Console.Write("Enter some text: ");
            //string userInput = Console.ReadLine();

            //// Loop to append user's input to each string in the array using the "<" operator
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    stringArray[i] = stringArray[i] + userInput;
            //}

            //// Loop to print off each string in the array
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    Console.WriteLine($"String {i + 1}: {stringArray[i]}");
            //}

            //// Loop to append user's input to each string in the array using the "<=" operator
            //int j = 0;
            //while (j <= stringArray.Length - 1)
            //{
            //    stringArray[j] = stringArray[j] + userInput;
            //    j++;
            //}

            //// Loop to print off each string in the array
            //int k = 0;
            //while (k <= stringArray.Length - 1)
            //{
            //    Console.WriteLine($"String {k + 1}: {stringArray[k]}");
            //    k++;
            //}

            //// Wait for the user to press a key before closing the console window
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            ////ASSIGNMENT 4

            //// Create a list of strings with unique items
            //List<string> stringList = new List<string>
            //{
            //    "apple", "pear", "banana", "mango", "pineapple"
            //};

            //// Ask the user to input text to search for in the list
            //Console.Write("Enter text to search for in the list: ");
            //string searchText = Console.ReadLine();

            //// Loop to search for the input text in the list
            //int foundIndex = -1;
            //for (int i = 0; i < stringList.Count; i++)
            //{
            //    if (stringList[i].Contains(searchText))
            //    {
            //        foundIndex = i;
            //        break; // Stop the loop once a match has been found
            //    }
            //}

            //// Check if a match was found or not
            //if (foundIndex >= 0)
            //{
            //    Console.WriteLine($"Match found at index: {foundIndex}");
            //}
            //else
            //{
            //    Console.WriteLine("Your input is not on the list.");
            //}

            //// Wait for the user to press a key before closing the console window
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            ////ASSIGNMENT 5

            //// Create a list of strings with at least two identical items
            //List<string> stringList = new List<string>
            //{
            //    "Apple", "Banana", "Cherry", "Apple", "Date", "Fig"
            //};

            //// Ask the user to select text to search for in the list
            //Console.Write("Enter text to search for in the list: ");
            //string searchText = Console.ReadLine();

            //// Loop to search for the input text in the list and display matching indices
            //List<int> foundIndices = new List<int>();
            //for (int i = 0; i < stringList.Count; i++)
            //{
            //    if (stringList[i].Contains(searchText))
            //    {
            //        foundIndices.Add(i); // Store the index of the matching item
            //    }
            //}

            //// Check if any matches were found or not
            //if (foundIndices.Count > 0)
            //{
            //    Console.WriteLine($"Matching text found at the following indices: {string.Join(", ", foundIndices)}");
            //}
            //else
            //{
            //    Console.WriteLine("Your input is not on the list.");
            //}

            //// Wait for the user to press a key before closing the console window
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            //ASSIGNMENT 6

            // Create a list of strings with at least two identical items
            List<string> stringList = new List<string>
            {
                "A", "B", "C", "D", "C"
            };

            // Create a dictionary to keep track of each string and its occurrence count
            Dictionary<string, int> stringOccurrences = new Dictionary<string, int>();

            // Loop to evaluate each item in the list and display the message
            foreach (string item in stringList)
            {
                // Check if the item exists in the dictionary
                if (stringOccurrences.ContainsKey(item))
                {
                    // If the item exists, it's a duplicate
                    stringOccurrences[item] += 1;
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
                else
                {
                    // If the item doesn't exist, it's unique
                    stringOccurrences[item] = 1;
                    Console.WriteLine($"{item} - this item is unique");
                }
            }

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

