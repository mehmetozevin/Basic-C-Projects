using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmitMethod
{
    public class MathOperations
    {
        // Void method that performs a math operation on the first integer
        // and displays the second integer to the screen
        public void PerformAndDisplay(int num1, int num2)
        {
            int result = num1 * 2; // Example operation: multiplication
            Console.WriteLine($"Result of the operation on {num1}: {result}");
            Console.WriteLine($"Second integer: {num2}");
        }
    }
}
