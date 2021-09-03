using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class PartRouteCostEstimateBracket
    {
        public int PartRouteCostEstimateBracketId { get; set; }
        public int PartRouteId { get; set; }
        public int? QuoteId { get; set; }
        public int MaxQuantity { get; set; }
        public decimal CostEstimate { get; set; }
        public ulong LotPricing { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual PartRoute PartRoute { get; set; }
        public virtual Quote Quote { get; set; }
    }
}
