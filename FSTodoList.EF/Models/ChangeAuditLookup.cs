using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class ChangeAuditLookup
    {
        public int ChangeAuditLookupId { get; set; }
        public string SourceProperty { get; set; }
        public string DestinationTable { get; set; }
        public string DestinationProperty { get; set; }
        public string DestinationDisplayField { get; set; }
    }
}
