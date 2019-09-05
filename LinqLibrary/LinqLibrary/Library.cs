using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqLibrary
{
    class Library
    {
        public Library()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }

        public string Name { get; set; }

        public string Address { get; set; }

        public Guid DistrictId { get; set; }
    }
}
