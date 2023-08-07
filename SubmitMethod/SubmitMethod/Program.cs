using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmitMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method in the class, passing in two numbers
            mathOps.PerformAndDisplay(5, 10);

            // Call the method in the class, specifying the parameters by name
            mathOps.PerformAndDisplay(num2: 20, num1: 3);

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
