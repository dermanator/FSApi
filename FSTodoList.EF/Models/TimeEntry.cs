using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TimeEntry
    {
        public TimeEntry()
        {
            XrefJobTimeEntries = new HashSet<XrefJobTimeEntry>();
        }

        public int TimeEntryId { get; set; }
        public int? TimeEntryTypeId { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public int UserId { get; set; }
        public int PayPeriodId { get; set; }
        public int? JobId { get; set; }
        public decimal? TimeInMinutes { get; set; }
        public ulong Violation { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual Job Job { get; set; }
        public virtual PayPeriod PayPeriod { get; set; }
        public virtual TypeTimeEntry TimeEntryType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<XrefJobTimeEntry> XrefJobTimeEntries { get; set; }
    }
}
