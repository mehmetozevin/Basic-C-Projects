using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1 : ");
            Console.WriteLine("Please type the hourly rate of person 1");
            string hourly1 = Console.ReadLine();
            int hourly1Int = Convert.ToInt32(hourly1);
            Console.WriteLine("How many hours does the person 1 work?");
            string hoursPerWeek1 = Console.ReadLine();
            int hoursPerWeek1Int = Convert.ToInt32(hoursPerWeek1);
            int annualSalary1 = (hourly1Int * hoursPerWeek1Int) * 52;
            //Console.WriteLine("Person 1 earns in a year " + annualSalary1);
            //Console.ReadLine();


            Console.WriteLine("Please type the hourly rate of person 2");
            string hourly2 = Console.ReadLine();
            int hourly2Int = Convert.ToInt32(hourly2);
            Console.WriteLine("How many hours does the person 2 work?");
            string hoursPerWeek2 = Console.ReadLine();
            int hoursPerWeek2Int = Convert.ToInt32(hoursPerWeek2);
            int annualSalary2 = (hourly2Int * hoursPerWeek2Int) * 52;


            Console.WriteLine("Annual Salary of the person 1 is: " + annualSalary1);
            Console.WriteLine("Annual Salary of the person 2 is: " + annualSalary2);

            bool makesmore = annualSalary1 > annualSalary2;
            Console.WriteLine("Person 1 makes more money than Person 2: " + makesmore);
            Console.ReadLine();

        }
    }
}
