using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypePayPeriodStatus
    {
        public TypePayPeriodStatus()
        {
            PayPeriods = new HashSet<PayPeriod>();
        }

        public int PayPeriodStatusId { get; set; }
        public string PayPeriodStatusName { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual ICollection<PayPeriod> PayPeriods { get; set; }
    }
}
