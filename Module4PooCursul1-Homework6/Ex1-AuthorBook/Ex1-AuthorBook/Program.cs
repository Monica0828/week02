using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_AuthorBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var author1 = new Author("Monica","wantsome@test.com","Romania");
            var book1 = new Book("Mos Craciun", author1, 2005, 12.5);
            Console.WriteLine($"The name of the author is {author1.Name}, the email is: {author1.Email} and the coutry is: {author1.Country}");

            Console.Write($"The name of the book is {book1.Name}, the author of the book is: {book1.AuthorOfBook.Name}, her email is {book1.AuthorOfBook.Email}" +
                $"and the country of the author is: {book1.AuthorOfBook.Country}. The year of the book is {book1.Year} and the price is {book1.Price}.");

            Console.ReadKey();
        }
    }
}
