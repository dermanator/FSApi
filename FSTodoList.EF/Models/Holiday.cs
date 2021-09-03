using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Holiday
    {
        public int HolidayId { get; set; }
        public int ScheduleId { get; set; }
        public DateTime HolidayDate { get; set; }
        public string HolidayName { get; set; }
        public int AllocatedHours { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
