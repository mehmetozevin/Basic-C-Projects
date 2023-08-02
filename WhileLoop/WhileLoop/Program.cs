using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int i = 0;
            while (i < daysOfWeek.Length)
            {
                Console.WriteLine(daysOfWeek[i]);
                i++;
            }

            int ii = 1;

            do
            {
                Console.WriteLine(ii);
                ii++;
            } while (ii <= 5);

            Console.ReadLine();
        }
    }

}

