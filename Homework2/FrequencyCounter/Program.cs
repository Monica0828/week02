using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, -10, 1, 0, 1, 2, -10, 10, 10 };
            int[] sortedArray = BubbleSortArray(numbers);

            Console.WriteLine("Sorted array is:");
            Helper.PrintArray(sortedArray);

            var x = sortedArray[0];
            var counter = 1;

            Console.WriteLine("Frequency:");
            for (var i = 1; i < sortedArray.Length; i++)
            {
                if (x == sortedArray[i])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"Number {sortedArray[i - 1]}:{counter} times");
                    x = sortedArray[i];
                    counter = 1;
                }
            }

            Console.WriteLine($"Number {sortedArray[sortedArray.Length - 1]}:{counter} times");
            Console.ReadKey();
        }

        private static int[] BubbleSortArray(int[] numbers)
        {
            var temp = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
