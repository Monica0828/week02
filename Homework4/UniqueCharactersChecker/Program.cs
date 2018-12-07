using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharactersChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas insert the word: ");
            var word = Console.ReadLine();

            var ok = true;
            var counter = 0;

            for (var i=0;i<word.Length;i++)
            {
                counter = 0;
                for(var j=0;j<word.Length;j++)
                {
                    if (word[i] == word[j]) counter++;
                }
                if(counter>1)
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
            {
                Console.WriteLine("Given word does have all unique characters");
            }
            else
            {
                Console.WriteLine("Given word does not have all unique characters");
            }
            Console.ReadKey();
        }
    }
}
