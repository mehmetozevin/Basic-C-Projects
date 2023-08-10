using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Prompt the user for a number
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            // Log the number to a text file
            using (StreamWriter writer = new StreamWriter("number_log.txt", true))
            {
                writer.WriteLine(userInput);
            }

            // Read and print the text file content back to the user
            using (StreamReader reader = new StreamReader("number_log.txt"))
            {
                string fileContent = reader.ReadToEnd();
                Console.WriteLine("Numbers logged in the file:");
                Console.WriteLine(fileContent);
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions that might occur
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
