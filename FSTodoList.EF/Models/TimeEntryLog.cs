using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TimeEntryLog
    {
        public int TimeEntryLogId { get; set; }
        public int TimeEntryId { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public int UserId { get; set; }
        public int PayPeriodId { get; set; }
        public int? JobId { get; set; }
        public int? JobFunctionId { get; set; }
        public int? TimeInMinutes { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? ActionDate { get; set; }
        public string ActionTaken { get; set; }

        public virtual Job Job { get; set; }
        public virtual JobFunction JobFunction { get; set; }
        public virtual PayPeriod PayPeriod { get; set; }
        public virtual User User { get; set; }
    }
}
