using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class PartMaterialQuoteEstimate
    {
        public int PartMaterialQuoteEstimateId { get; set; }
        public int? PartMaterialId { get; set; }
        public int PartId { get; set; }
        public int MaterialId { get; set; }
        public int QuoteId { get; set; }
        public decimal CostEstimate { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual XrefPartMaterial PartMaterial { get; set; }
        public virtual Quote Quote { get; set; }
    }
}
