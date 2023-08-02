using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Mehmet ";
            //string middleName = "Ugur ";
            //string lastName = "Deniz";

            //string fullName = firstName + middleName + lastName; // this string is to concatenate 3 strings
            //string allUppered = fullName.ToUpper(); // this code is to convert all letter to upper

            //Console.WriteLine(fullName);
            //Console.WriteLine(allUppered);
            //Console.ReadLine();

            StringBuilder mum = new StringBuilder();
                mum.Append("Fatma ");
                mum.Append("Deniz");
            Console.WriteLine(mum.ToString());
            Console.ReadLine();




        }
    }
}
