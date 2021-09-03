using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class InProcessOperation
    {
        public InProcessOperation()
        {
            InProcessInspectionItems = new HashSet<InProcessInspectionItem>();
        }

        public int OperationId { get; set; }
        public int PartId { get; set; }
        public string OperationName { get; set; }
        public int Interval { get; set; }
        public int Sequence { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Part Part { get; set; }
        public virtual ICollection<InProcessInspectionItem> InProcessInspectionItems { get; set; }
    }
}
