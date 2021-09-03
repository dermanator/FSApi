using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Timesheet
    {
        public int TimesheetId { get; set; }
        public int PayPeriodId { get; set; }
        public DateTime? StartDay { get; set; }
        public DateTime? EndDay { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? IsFullTimeEmployee { get; set; }
        public decimal? RegularHours { get; set; }
        public decimal? OverTimeHours { get; set; }
        public decimal? VacationHours { get; set; }
        public decimal? HolidayHours { get; set; }

        public virtual PayPeriod PayPeriod { get; set; }
        public virtual User User { get; set; }
    }
}
