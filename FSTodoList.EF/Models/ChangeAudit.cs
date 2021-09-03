using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class ChangeAudit
    {
        public int ChangeId { get; set; }
        public string Entity { get; set; }
        public string EntityId { get; set; }
        public string Reason { get; set; }
        public int InitiatedById { get; set; }
        public DateTime InitiatedDate { get; set; }
        public int? ClosedById { get; set; }
        public DateTime? ClosedDate { get; set; }
    }
}
