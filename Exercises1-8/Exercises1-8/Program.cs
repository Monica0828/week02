using System;

namespace Exercises1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6] { 1, 15, 3, 4, 2, 7 };
            int[] numbers2 = new int[3] { 1, 2, 3 };
            var value = 15;
            var index = 3;

            var sum = Sum(numbers);
            double average = sum / numbers.Length;
            Console.WriteLine("Your array is: ");
            Helper.PrintArray(numbers);

            Console.WriteLine("Sum from array is: " + sum);

            Console.WriteLine("Average from array elements are is: " + average);

            Console.WriteLine("Please insert the number you want to search: ");
            int searcherNumber = Convert.ToInt32(Console.ReadLine());

            var indexFound = FindIndex(numbers, searcherNumber);
            if (indexFound == -1) Console.WriteLine("Number was not found in array.");
            else Console.WriteLine("Index of searched element is: " + indexFound);

            Console.WriteLine($"Max value from array is: {FindMax(numbers)}");
            Console.WriteLine($"Min value from array is: {FindMin(numbers)}");

            Console.WriteLine("Second array is: ");
            Helper.PrintArray(numbers2);
            PrintCommon(numbers, numbers2);

            var newArray = CopyArray(numbers);

            Console.WriteLine("Values from new array are: ");
            Helper.PrintArray(newArray);


            int[] newArray2 = RemoveElementFromArray(numbers, value);
            Console.WriteLine("Values from new array, with elements removed: ");
            Helper.PrintArray(newArray2);

            int[] newArray3 = InsertIntoArray(numbers, index, value);
            Console.WriteLine("Values from new array, with element inserted: ");
            Helper.PrintArray(newArray3);


            Console.ReadKey();
        }
        public static double Sum(int[] array)
        {
            var sum = 0;
            for (var i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }
        public static int FindIndex(int[] array, int searchedNumber)
        {
            int index = -1;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == searchedNumber)
                    index = i;
            }
            return index;
        }

        public static int FindMax(int[] array)
        {
            var max = array[0];
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }
            return max;
        }
        public static int FindMin(int[] array)
        {
            var min = array[0];
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
            }
            return min;
        }
        public static void PrintCommon(int[] array1, int[] array2)
        {
            var areCommon = false;

            for (var i = 0; i < array1.Length; i++)
            {
                for (var j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        Console.WriteLine($"Common value: {array1[i]}");
                        areCommon = true;
                        break;
                    }
                }
            }
            if (!areCommon) Console.WriteLine("There are no common values.");
        }
        public static int[] CopyArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }
        public static int FindOccurencies(int[] array, int value)
        {
            var counter = 0;

            foreach (var element in array)
            {
                if (element == value) counter++;
            }

            return counter;
        }
        public static int[] RemoveElementFromArray(int[] array, int removedValue)
        {
            var numberOfCommonElements = FindOccurencies(array, removedValue);
            var counter = 0;

            int[] newArray = new int[array.Length - numberOfCommonElements];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == removedValue)
                {
                    continue;
                }
                newArray[counter++] = array[i];
            }
            return newArray;
        }
        public static int[] InsertIntoArray(int[] array, int index, int value)
        {
            var counter = 0;

            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    newArray[counter++] = value;
                    newArray[counter++] = array[i];
                }
                else
                {
                    newArray[counter++] = array[i];
                }
            }
            return newArray;
        }
    }
}
