using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqLibrary
{
    class BookItem
    {
        public BookItem()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
        
        public Guid BookId { get; set; }

        public Guid EditionId { get; set; }

        public string Format { get; set; }

        public Guid LibraryId { get; set; }
    }
}
