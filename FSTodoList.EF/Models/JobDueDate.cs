using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class JobDueDate
    {
        public int JobDueDateId { get; set; }
        public int JobId { get; set; }
        public DateTime DueDate { get; set; }
        public int Quantity { get; set; }
        public ulong Fulfilled { get; set; }
        public DateTime? FulfilledDate { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual Job Job { get; set; }
        public virtual User UpdatedBy { get; set; }
    }
}
