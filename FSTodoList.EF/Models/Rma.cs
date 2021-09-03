using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Rma
    {
        public int RmaId { get; set; }
        public int OrderId { get; set; }
        public int RmaStatusTypeId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual TypeRmaStatus RmaStatusType { get; set; }
    }
}
