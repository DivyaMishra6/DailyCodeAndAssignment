using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Leapyear
    {
        public static void year()
        {
            Console.WriteLine("Enter the year:");
            string input = Console.ReadLine();

            int length = input.Length;


            if(length == 4)
            {
                int newyear = Convert.ToInt32(input);

                if (newyear % 4 == 0)
                {
                    Console.WriteLine("this is a leap year");
                }

                else
                {
                    Console.WriteLine("This is not leap year");
                }
            }
              
            else
            {
                Console.WriteLine("Invalid number");
            }

        }
    }
}
