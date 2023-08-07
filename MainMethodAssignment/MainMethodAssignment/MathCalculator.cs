using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class MathCalculator
    {
        // Method to perform math operation on an integer
        public int PerformOperation(int num)
        {
            return num + 10; // Example operation: addition
        }

        // Method to perform math operation on a decimal
        public int PerformOperation(decimal num)
        {
            return (int)(num * 2); // Example operation: multiplication
        }

        // Method to perform math operation on a string (if it's a valid integer)
        public int PerformOperation(string input)
        {
            if (int.TryParse(input, out int num))
            {
                return num - 5; // Example operation: subtraction
            }
            else
            {
                return 0; // Invalid input, return 0
            }
        }
    }
}
