using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class VwTimeEntrySummedByDay
    {
        public int PayPeriodId { get; set; }
        public int UserId { get; set; }
        public DateTime? DayWorked { get; set; }
        public decimal? TotalWorkedHours { get; set; }
        public decimal? TotalVacationHours { get; set; }
        public decimal? TotalHolidayHours { get; set; }
    }
}
