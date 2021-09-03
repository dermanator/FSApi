using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class EmployeePerformance
    {
        public int EmployeePerformanceId { get; set; }
        public int? UserId { get; set; }
        public int JobId { get; set; }
        public int? Qty { get; set; }
        public decimal Hours { get; set; }
        public ulong Pass { get; set; }
        public int? RejectionReasonId { get; set; }
        public DateTime Date { get; set; }
        public int? FeaturesInspected { get; set; }
        public int? InspectorUserId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Job Job { get; set; }
        public virtual User User { get; set; }
    }
}
