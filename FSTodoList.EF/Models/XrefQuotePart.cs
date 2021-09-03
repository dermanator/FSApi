using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefQuotePart
    {
        public XrefQuotePart()
        {
            InverseParentQuotePart = new HashSet<XrefQuotePart>();
        }

        public int QuotePartId { get; set; }
        public int? ParentQuotePartId { get; set; }
        public int QuoteId { get; set; }
        public int PartId { get; set; }
        public ulong IsSelected { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ExtendedPrice { get; set; }
        public decimal? TargetUnitPrice { get; set; }
        public decimal? TargetExtendedPrice { get; set; }
        public bool NoQuote { get; set; }
        public bool HasUpdates { get; set; }
        public int ItemId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual XrefQuotePart ParentQuotePart { get; set; }
        public virtual Part Part { get; set; }
        public virtual Quote Quote { get; set; }
        public virtual ICollection<XrefQuotePart> InverseParentQuotePart { get; set; }
    }
}
