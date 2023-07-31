using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Larning College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("Please type your name:");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on? :");
            string course = Console.ReadLine();
            Console.WriteLine("What page number? :");
            int pageNumber = Convert.ToInt32(Console.ReadLine()); // //input is recorded as integer directly
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string help = Console.ReadLine();
            bool helpbool = bool.Parse(help);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");
            string specifics = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hoursOfStudy = Convert.ToInt32(Console.ReadLine()); //input is recorded as integer directly
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Thread.Sleep(5000); //to give some time for final message to be read


        }
    }
}
