using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathCalculator class
            MathCalculator calculator = new MathCalculator();

            // Call the method for integer and display the result
            int resultInt = calculator.PerformOperation(15);
            Console.WriteLine($"Result for integer: {resultInt}");

            // Call the method for decimal and display the result
            decimal inputDecimal = 3.5M;
            int resultDecimal = calculator.PerformOperation(inputDecimal);
            Console.WriteLine($"Result for decimal: {resultDecimal}");

            // Call the method for string and display the result
            string inputString = "10";
            int resultString = calculator.PerformOperation(inputString);
            Console.WriteLine($"Result for string: {resultString}");

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
