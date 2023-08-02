using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseElseIf_Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of the package you want it to be shipped?");
            int weightP = Convert.ToInt32(Console.ReadLine());
            if (weightP >= 50) // weight is asked. if bigger than 50, program will end here
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the width of the package you want it to be shipped?");
            }
            int widthP = Convert.ToInt32(Console.ReadLine()); // dimensions of the package is asked
            Console.WriteLine("Please enter the height");
            int heightP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the length");
            int lenghtP = Convert.ToInt32(Console.ReadLine());
            if (widthP + heightP + lenghtP >= 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine( "Your estimated total for shipping this package is:" + ((widthP*heightP*lenghtP )* weightP)/100 + " "); // calculation for the quote and the message part
            }
            Console.ReadLine();
        }
    }
}
