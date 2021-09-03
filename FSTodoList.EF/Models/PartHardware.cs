using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class PartHardware
    {
        public PartHardware()
        {
            PartHardwareQuoteEstimates = new HashSet<PartHardwareQuoteEstimate>();
        }

        public int PartHardwareId { get; set; }
        public int PartId { get; set; }
        public int HardwareId { get; set; }
        public int? Quantity { get; set; }
        public ulong CertificationRequired { get; set; }
        public decimal? CostEstimate { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Hardware Hardware { get; set; }
        public virtual Part Part { get; set; }
        public virtual ICollection<PartHardwareQuoteEstimate> PartHardwareQuoteEstimates { get; set; }
    }
}
