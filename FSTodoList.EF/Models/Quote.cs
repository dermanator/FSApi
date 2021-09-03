using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Quote
    {
        public Quote()
        {
            Orders = new HashSet<Order>();
            PartHardwareQuoteEstimates = new HashSet<PartHardwareQuoteEstimate>();
            PartMaterialQuoteEstimates = new HashSet<PartMaterialQuoteEstimate>();
            PartRouteCostEstimateBrackets = new HashSet<PartRouteCostEstimateBracket>();
            XrefQuoteParts = new HashSet<XrefQuotePart>();
        }

        public int QuoteId { get; set; }
        public int QuoteStatusId { get; set; }
        public string QuoteNumber { get; set; }
        public string Rfqnumber { get; set; }
        public DateTime QuoteDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int? CustomerId { get; set; }
        public int? PaymentTermsTypeId { get; set; }
        public int? PrimaryCustomerContactId { get; set; }
        public int? PrimaryCustomerShippingAddressId { get; set; }
        public int? SalesContactUserId { get; set; }
        public decimal Total { get; set; }
        public string Notes { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }
        public uint? QuotedByUserId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual TypePaymentTerm PaymentTermsType { get; set; }
        public virtual Contact PrimaryCustomerContact { get; set; }
        public virtual Address PrimaryCustomerShippingAddress { get; set; }
        public virtual TypeQuoteStatus QuoteStatus { get; set; }
        public virtual User SalesContactUser { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PartHardwareQuoteEstimate> PartHardwareQuoteEstimates { get; set; }
        public virtual ICollection<PartMaterialQuoteEstimate> PartMaterialQuoteEstimates { get; set; }
        public virtual ICollection<PartRouteCostEstimateBracket> PartRouteCostEstimateBrackets { get; set; }
        public virtual ICollection<XrefQuotePart> XrefQuoteParts { get; set; }
    }
}
