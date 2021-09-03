using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
        }

        public int PurchaseOrderId { get; set; }
        public int PurchaseOrderTypeId { get; set; }
        public int PurchaseOrderStatusId { get; set; }
        public int? ContactId { get; set; }
        public int? SalesTaxCodeTypeId { get; set; }
        public int? ShippingCodeTypeId { get; set; }
        public int? PaymentTermsTypeId { get; set; }
        public int? VendorId { get; set; }
        public int? AddressId { get; set; }
        public ulong CityUseTax { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ExpectedArrivalDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? ShippingCost { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalCost { get; set; }
        public string Notes { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual TypePaymentTerm PaymentTermsType { get; set; }
        public virtual TypePurchaseOrderStatus PurchaseOrderStatus { get; set; }
        public virtual TypePurchaseOrder PurchaseOrderType { get; set; }
        public virtual TypeShippingCode ShippingCodeType { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    }
}
