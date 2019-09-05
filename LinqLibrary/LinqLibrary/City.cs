using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqLibrary
{
    class City
    {
        public City()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }

        public string Name { get; set; }
    }
}
