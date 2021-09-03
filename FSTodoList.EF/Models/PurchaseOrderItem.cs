using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class PurchaseOrderItem
    {
        public PurchaseOrderItem()
        {
            ReceiverItems = new HashSet<ReceiverItem>();
            XrefJobItemPurchaseOrderItems = new HashSet<XrefJobItemPurchaseOrderItem>();
            XrefPurchaseOrderItemBins = new HashSet<XrefPurchaseOrderItemBin>();
        }

        public int PurchaseOrderItemId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int LineItemNumber { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public ulong CertificationRequired { get; set; }
        public ulong PurchaseSlug { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime MinimumJobDueDate { get; set; }
        public int? Extra { get; set; }
        public int? OrderTotal { get; set; }
        public int? PackageQuantity { get; set; }
        public int PurchaseQuantity { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public decimal? UnitPrice { get; set; }
        public string PurchaseUom { get; set; }
        public decimal? ExtendedPrice { get; set; }
        public ulong HasCityUseTax { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual ICollection<ReceiverItem> ReceiverItems { get; set; }
        public virtual ICollection<XrefJobItemPurchaseOrderItem> XrefJobItemPurchaseOrderItems { get; set; }
        public virtual ICollection<XrefPurchaseOrderItemBin> XrefPurchaseOrderItemBins { get; set; }
    }
}
