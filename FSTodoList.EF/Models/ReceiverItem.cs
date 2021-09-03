using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class ReceiverItem
    {
        public ReceiverItem()
        {
            VendorInvoiceItems = new HashSet<VendorInvoiceItem>();
        }

        public int ReceiverItemId { get; set; }
        public int ReceiverId { get; set; }
        public int ReceivedQty { get; set; }
        public int? JobMaterialId { get; set; }
        public int? JobHardwareId { get; set; }
        public int? JobRouteId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? PurchaseOrderItemId { get; set; }

        public virtual JobHardware JobHardware { get; set; }
        public virtual JobMaterial JobMaterial { get; set; }
        public virtual JobRoute JobRoute { get; set; }
        public virtual PurchaseOrderItem PurchaseOrderItem { get; set; }
        public virtual Receiver Receiver { get; set; }
        public virtual ICollection<VendorInvoiceItem> VendorInvoiceItems { get; set; }
    }
}
