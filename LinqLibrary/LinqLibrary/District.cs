using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqLibrary
{
    class District
    {
        public District()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }

        public string Name { get; set; }

        public Guid CityId { get; set; }
    }
}
