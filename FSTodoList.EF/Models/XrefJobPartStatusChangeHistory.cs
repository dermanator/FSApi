using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefJobPartStatusChangeHistory
    {
        public int JobPartStatusChangeHistoryId { get; set; }
        public int JobId { get; set; }
        public int? OldCellId { get; set; }
        public int? NewCellId { get; set; }
        public int? OldJobPartStatusId { get; set; }
        public int NewJobPartStatusId { get; set; }
        public int? OldSubmittedById { get; set; }
        public int? NewSubmittedById { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public int Qty { get; set; }
        public string Notes { get; set; }
        public int? InspectionPriority { get; set; }
        public int? RejectionReasonId { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Cell NewCell { get; set; }
        public virtual TypeJobPartStatus NewJobPartStatus { get; set; }
        public virtual User NewSubmittedBy { get; set; }
        public virtual Cell OldCell { get; set; }
        public virtual TypeJobPartStatus OldJobPartStatus { get; set; }
        public virtual User OldSubmittedBy { get; set; }
        public virtual TypeRejectionReason RejectionReason { get; set; }
    }
}
