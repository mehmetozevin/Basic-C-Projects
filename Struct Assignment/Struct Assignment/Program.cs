using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        // Define a struct named Number with a decimal property "Amount"
        struct Number
        {
            public decimal Amount { get; set; }
        }

        static void Main(string[] args)
        {
            // Create an object of data type Number
            Number num = new Number();

            try
            {
                // Prompt the user to enter an amount
                Console.Write("Enter an amount: ");
                num.Amount = decimal.Parse(Console.ReadLine());

                // Print the entered amount
                Console.WriteLine($"Amount entered: {num.Amount}");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during input or conversion
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
