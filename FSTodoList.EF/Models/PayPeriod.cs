using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class PayPeriod
    {
        public PayPeriod()
        {
            TimeEntries = new HashSet<TimeEntry>();
            TimeEntryLogs = new HashSet<TimeEntryLog>();
            Timesheets = new HashSet<Timesheet>();
        }

        public int PayPeriodId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int PayPeriodStatusId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual TypePayPeriodStatus PayPeriodStatus { get; set; }
        public virtual ICollection<TimeEntry> TimeEntries { get; set; }
        public virtual ICollection<TimeEntryLog> TimeEntryLogs { get; set; }
        public virtual ICollection<Timesheet> Timesheets { get; set; }
    }
}
