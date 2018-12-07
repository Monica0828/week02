using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 0, 10, 23, 14, 9043, 12, 3, 5, -10 };
            int oddNumbers = 0, evenNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) evenNumbers++;
                else oddNumbers++;
            }

            int[] oddNumbersArray = new int[oddNumbers];
            int[] evenNumbersArray = new int[evenNumbers];

            oddNumbers = 0;
            evenNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) evenNumbersArray[evenNumbers++] = numbers[i];
                else oddNumbersArray[oddNumbers++] = numbers[i];
            }

            Console.WriteLine("Odd numbers are: ");
            Helper.PrintArray(oddNumbersArray);

            Console.WriteLine();

            Console.WriteLine("Even numbers are: ");
            Helper.PrintArray(evenNumbersArray);

            Console.ReadKey();
        }

    }
}
