using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class PowerOfN
    {
        public static void call()
        {
            Console.WriteLine("Please Enter the number");

            int N = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= N; i++)
            {
             Console.WriteLine($"{ 2}*{ i} = { (long)Math.Pow(2,i): No}");
            }
        }
    }
}
