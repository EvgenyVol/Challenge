using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqLibrary
{
    class History
    {
        public History()
        {
            HistoryId = Guid.NewGuid();
        }

        public Guid HistoryId;

        public Guid VisitorId; 

        public Guid BookItemId;

        public Guid LibraryId;

        public string VisitorAction;

        public DateTime Date;
    }
}
