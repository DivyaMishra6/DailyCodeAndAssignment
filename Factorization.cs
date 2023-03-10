using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Factorization
    {
        public static void call()
        {
            Console.WriteLine("Enter the value for prime Factorization:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i * i < n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i);
                    n /= i;
                }
            }
            if (n>2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
