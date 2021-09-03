using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefJobPart
    {
        public XrefJobPart()
        {
            PackingListJobParts = new HashSet<PackingListJobPart>();
        }

        public int JobPartId { get; set; }
        public int JobId { get; set; }
        public int? CellId { get; set; }
        public int JobPartStatusId { get; set; }
        public int? SubmittedById { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public int? JobPartBatchId { get; set; }
        public int? BinId { get; set; }
        public int Quantity { get; set; }
        public int? InspectionPriority { get; set; }
        public ulong ExtraInspectionReview { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Bin Bin { get; set; }
        public virtual Cell Cell { get; set; }
        public virtual Job Job { get; set; }
        public virtual JobPartBatch JobPartBatch { get; set; }
        public virtual TypeJobPartStatus JobPartStatus { get; set; }
        public virtual User SubmittedBy { get; set; }
        public virtual ICollection<PackingListJobPart> PackingListJobParts { get; set; }
    }
}
