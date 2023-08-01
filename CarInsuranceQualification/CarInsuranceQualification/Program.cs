using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceQualification
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lets check if you are qualified for a car insurance");
            Console.WriteLine("What is your age?");
            int ageInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Reply true or false");
            string everDUI = Console.ReadLine();
            bool EverDuiBool = Boolean.Parse(everDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTicketInt = Convert.ToInt32(Console.ReadLine());

            bool isQualified = ageInt >= 15 && EverDuiBool == false && speedingTicketInt <= 3;

            Console.WriteLine("The person you have had entered their details is qualified for DUI?: " + isQualified);
            Console.ReadLine();
        }
    }
}
