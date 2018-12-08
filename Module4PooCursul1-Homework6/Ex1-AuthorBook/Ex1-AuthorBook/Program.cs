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
            var author1 = new Author("Monica", "wantsome@test.com", "Romania");
            var book1 = new Book("Iarna pe ulita", author1, 2005, 12.5);
            Console.WriteLine(author1.Print());
            Console.WriteLine(book1.Print());
            Console.ReadKey();
        }
    }
}
