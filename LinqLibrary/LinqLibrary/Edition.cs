using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqLibrary
{
    class Edition
    {
        public Edition()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }

        public int NumberEdition { get; set; }

        public int NumberPages { get; set; }
    }
}
