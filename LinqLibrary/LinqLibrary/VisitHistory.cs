using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqLibrary
{
    class VisitHistory
    {
        public VisitHistory()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }

        public Guid VisitorId { get; set; }

        public string Action { get; set; }

        public BookItem BookItem { get; set; }

        public DateTime Date { get; set; }
    }
}
