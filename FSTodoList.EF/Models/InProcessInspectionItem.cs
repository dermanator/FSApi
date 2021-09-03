using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class InProcessInspectionItem
    {
        public int InspectionItemId { get; set; }
        public int OperationId { get; set; }
        public int ItemNumber { get; set; }
        public decimal? Dimension { get; set; }
        public string Feature { get; set; }
        public decimal? PlusTolerance { get; set; }
        public decimal? MinusTolerance { get; set; }
        public ulong HundredPercent { get; set; }
        public int? ToolNumber { get; set; }
        public int Sequence { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual InProcessOperation Operation { get; set; }
    }
}
