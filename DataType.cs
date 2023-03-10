using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class DataType
    {
        public static void display (string[] args)
        {
            int a = 10;
            int b = 20;
            char ch = 'P';
            bool val = true;
            string str = "Bridgelab";
            Console.WriteLine("Hello World");
            Console.WriteLine("The integer value is " + a + b);
            Console.WriteLine("The Character is:" + ch);
            Console.WriteLine(a + b);
            Console.WriteLine(" The bool value is:" + val);
            Console.WriteLine("Enter String" + str);

            Console.WriteLine("Please Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("The name of the Person" +name);


        }
    }
}
