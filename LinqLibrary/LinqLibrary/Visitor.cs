using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqLibrary
{
    class Visitor
    {
        public Visitor()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
    }
}
