using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("You are talking to a calculator now");
            Thread.Sleep(1000);
            Console.WriteLine("I will be receiving input and perform some operations on them...");
            Thread.Sleep(1000);
            Console.WriteLine("What number you want to be multiplied by 50?");
            Thread.Sleep(1000);
            string multi50 = Console.ReadLine();
            int multi50Int = Convert.ToInt32(multi50);
            int result = multi50Int * 50;
            Thread.Sleep(1000);
            Console.WriteLine("When we multiply " + multi50 + " with 50, the result would be: " + result);
            Thread.Sleep(1000);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(); // This will create an empty line (gap).
            }


            /////// Second part, adding 25 to the input received from the user

            Console.WriteLine("Now we will be adding 25 to your picked number");
            Thread.Sleep(1000);
            Console.WriteLine("Pick a number: ");
            string add25 = Console.ReadLine();
            int add25Int = Convert.ToInt32(add25);
            int result25 = add25Int + 25;
            Thread.Sleep(1000);
            Console.WriteLine(add25 + " plus 25 would be: " + result25);
            Thread.Sleep(2000);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(); // This will create an empty line (gap).
            }


            //// 3rd, divide 12.5

            Console.WriteLine("Lets try divinding your picked number to 12.5...");
            Thread.Sleep(1000);
            Console.WriteLine("What number shall we divide? : ");
            string divide12 = Console.ReadLine();
            float divide12fl = float.Parse(divide12);
            float result12 = divide12fl / 12.5f;
            Thread.Sleep(1000);
            Console.WriteLine("when " + divide12 + " is divided to 12.5, the result is: " + result12);
            Thread.Sleep(3000);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(); // This will create an empty line (gap).
            }

            // greater than or?

            Console.WriteLine("Lets check if the input is greater or smaller than 50");
            string ifgreater = Console.ReadLine();
            int ifgreaterInt = Convert.ToInt32(ifgreater);
            bool ifgreaterbool = ifgreaterInt > 50;
            Console.WriteLine(ifgreater + " is greater than 50? : " + ifgreaterbool);
            Thread.Sleep(3000);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(); // This will create an empty line (gap).
            }


            //// remainder sample

            Console.WriteLine("Now I will tell you the remainder of your picked number, when its dividend to 7");
            string dividend7 = Console.ReadLine();
            int dividend7Int = Convert.ToInt32(dividend7);
            int dividendresult = dividend7Int % 7;
            Console.WriteLine(dividendresult + " is the result when we divide " + dividend7 + " to 7." );
            Console.ReadLine();






        }
    }
}
