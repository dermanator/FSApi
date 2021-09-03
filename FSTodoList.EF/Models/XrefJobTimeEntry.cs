using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefJobTimeEntry
    {
        public int JobTimeEntryId { get; set; }
        public int? JobId { get; set; }
        public int? JobFunctionId { get; set; }
        public int TimeEntryId { get; set; }
        public int? CellId { get; set; }
        public decimal? TimeInMinutes { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Cell Cell { get; set; }
        public virtual Job Job { get; set; }
        public virtual JobFunction JobFunction { get; set; }
        public virtual TimeEntry TimeEntry { get; set; }
    }
}
