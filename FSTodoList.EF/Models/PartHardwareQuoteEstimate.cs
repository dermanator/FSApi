using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class PartHardwareQuoteEstimate
    {
        public int PartHardwareQuoteEstimateId { get; set; }
        public int PartHardwareId { get; set; }
        public int QuoteId { get; set; }
        public decimal CostEstimate { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual PartHardware PartHardware { get; set; }
        public virtual Quote Quote { get; set; }
    }
}
