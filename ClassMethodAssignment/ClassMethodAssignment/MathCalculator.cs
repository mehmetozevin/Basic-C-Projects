using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public class MathCalculator
    {
        // Void method that divides the data passed to it by 2
        public void DivideByTwo(int num)
        {
            int result = num / 2;
            Console.WriteLine($"Result after dividing {num} by 2: {result}");
        }

        // Method with output parameters
        public void CalculateSumAndDifference(int num1, int num2, out int sum, out int difference)
        {
            sum = num1 + num2;
            difference = num1 - num2;
        }

        // Overloaded method
        public void CalculateSumAndDifference(double num1, double num2, out double sum, out double difference)
        {
            sum = num1 + num2;
            difference = num1 - num2;
        }
    }
}
