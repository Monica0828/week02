using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var ok = true;
            for (var i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }

            Console.ReadKey();

        }
    }
}
