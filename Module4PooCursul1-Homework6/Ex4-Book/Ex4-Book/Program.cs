using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfBooks = new List<Book>();
            listOfBooks.Add(new Book("The cacher in the rye", "J.D. Salinger", 20.5));
            listOfBooks.Add(new Book("Invitatie la dans", "Mihail Drumes",15.4));
            listOfBooks.Add(new Book("The Alchemist", "Paulo Choelo", 50.5));
            listOfBooks.Add(new Book("The Martian", "Andi Weir", 70.5));
            listOfBooks.Add(new Book("The Ocean at the End of the Lane", "Neil Gaiman", 46.5));
            int count = 0;
            foreach(var elem in listOfBooks)
            {
                if(count==1 || count==3)
                {
                    elem.Price = elem.Price * 1.5;
                    elem.Title = elem.Title.ToUpper();
                    Console.WriteLine(elem.Print());
                }
                else
                {
                    Console.WriteLine(elem.Print());

                }
                count++;
            }
            Console.ReadKey();

        }
    }
}
