using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElementChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6] { 1, 15, 3, 4, 2, 7 };
            int[] numbers2 = new int[3] { 1, 2, 3 };

            PrintCommon(numbers, numbers2);

            Console.ReadKey();
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
    }
}
