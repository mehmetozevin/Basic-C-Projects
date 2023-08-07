using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class MathOperations
    {
        // Method with optional second parameter
        public int PerformOperation(int num1, int num2 = 0)
        {
            return num1 + num2; // Example operation: addition
        }
    }
}
