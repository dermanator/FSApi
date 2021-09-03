using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class JobFunction
    {
        public JobFunction()
        {
            TimeEntryLogs = new HashSet<TimeEntryLog>();
            XrefJobTimeEntries = new HashSet<XrefJobTimeEntry>();
        }

        public int JobFunctionId { get; set; }
        public string JobFunctionName { get; set; }
        public string JobFunctionDescription { get; set; }
        public sbyte? RequiresJob { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual ICollection<TimeEntryLog> TimeEntryLogs { get; set; }
        public virtual ICollection<XrefJobTimeEntry> XrefJobTimeEntries { get; set; }
    }
}
