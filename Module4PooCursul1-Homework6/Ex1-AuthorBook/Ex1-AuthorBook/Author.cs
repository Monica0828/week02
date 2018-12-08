using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_AuthorBook
{
    public class Author
    {
        public Author(string name, string email, string country)
        {
            Name = name;
            Email = email;
            Country = country;
        }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }


        public string Print()
        {
            return $"The name of the author is {Name}, the email is: {Email} and the coutry is: {Country}";
        }
    }
}
