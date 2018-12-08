using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_AuthorBook
{
    class Book
    {
        public Book(string name, Author auhor1, int year, double price)
        {
            Name = name;
            AuthorOfBook = auhor1;
            Year = year;
            Price = price;
        }
        public string Name { get; set; }

        public Author AuthorOfBook { get; set; }

        public int Year { get; set; }

        public double Price { get; set; }
    }
}
