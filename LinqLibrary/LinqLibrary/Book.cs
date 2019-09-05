using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqLibrary
{
    class Book
    {
        public Book()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }

        public string Author { get; set; }

        public string Title { get; set; }

        public string BookGenre { get; set; }
    }
}
