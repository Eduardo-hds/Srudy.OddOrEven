using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srudy.OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int r;

            Console.WriteLine("This program verify the number and tell us if the number is odd ou even.");
            Console.WriteLine("Tell us the number");

            n = Convert.ToInt32(Console.ReadLine());

            r = n % 2;

            if (r > 0)
            {
                Console.WriteLine("The number {0} is odd.", n);
            } if (r == 0)
            {
                Console.WriteLine("The number {0} is even", n);
            }

            Console.ReadKey();
        }
    }
}
