using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class VwTimeEntry
    {
        public int TimeEntryId { get; set; }
        public int PayPeriodId { get; set; }
        public int UserId { get; set; }
        public DateTime? DayWorked { get; set; }
        public int? TimeEntryTypeId { get; set; }
        public decimal? TotalWorkedHours { get; set; }
        public decimal? TotalVacationHours { get; set; }
        public decimal? TotalHolidayHours { get; set; }
    }
}
