using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeTimeEntry
    {
        public TypeTimeEntry()
        {
            TimeEntries = new HashSet<TimeEntry>();
        }

        public int TimeEntryTypeId { get; set; }
        public string TimeEntryTypeName { get; set; }
        public string TimeEntryTypeDescription { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual ICollection<TimeEntry> TimeEntries { get; set; }
    }
}
