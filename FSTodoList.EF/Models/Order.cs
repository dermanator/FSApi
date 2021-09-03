using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class Order
    {
        public Order()
        {
            Jobs = new HashSet<Job>();
            PackingLists = new HashSet<PackingList>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? PaymentTermsTypeId { get; set; }
        public int? OrderStatusTypeId { get; set; }
        public int? PrimaryCustomerContactId { get; set; }
        public int? PrimaryCustomerShippingAddressId { get; set; }
        public DateTime OrderDate { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public DateTime? DueDate { get; set; }
        public string QuoteNumber { get; set; }
        public decimal OrderTotal { get; set; }
        public int SalesId { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? ClonedFromQuoteId { get; set; }

        public virtual Quote ClonedFromQuote { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual TypeOrderStatus OrderStatusType { get; set; }
        public virtual TypePaymentTerm PaymentTermsType { get; set; }
        public virtual Contact PrimaryCustomerContact { get; set; }
        public virtual Address PrimaryCustomerShippingAddress { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<PackingList> PackingLists { get; set; }
    }
}
