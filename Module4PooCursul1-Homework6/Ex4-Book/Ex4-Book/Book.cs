using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Book
{
    class Book
    {
        public Book (string title, string author, double price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public string Author { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public string Print()
        {
            return $"Author of the book is {Author}, the title is {Title} and the price is {Price}";
        }
    }
}
