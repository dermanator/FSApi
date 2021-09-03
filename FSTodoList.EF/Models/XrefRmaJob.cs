using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefRmaJob
    {
        public XrefRmaJob()
        {
            RmaJobNotes = new HashSet<RmaJobNote>();
        }

        public int RmaJobId { get; set; }
        public int RmaId { get; set; }
        public int OrigJobId { get; set; }
        public int? NewJobId { get; set; }
        public int? RmaQty { get; set; }
        public int? RmaJobTypeId { get; set; }
        public ulong CreditMemo { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<RmaJobNote> RmaJobNotes { get; set; }
    }
}
