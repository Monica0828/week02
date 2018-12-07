using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas insert the word: ");
            var word = Console.ReadLine();
            var ok = true;

            for (var i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    ok = false;
                    break;
                }
            }
            if (ok)
            {
                Console.WriteLine("Given word is a palindrome");
            }
            else
            {
                Console.WriteLine("Given word is not a palindrome");
            }
            Console.ReadKey();

        }


    }
}
