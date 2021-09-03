using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class VendorInvoiceItem
    {
        public int VendorInvoiceItemId { get; set; }
        public int VendorInvoiceId { get; set; }
        public int ReceiverItemId { get; set; }
        public int? InvoiceQuantity { get; set; }
        public decimal? InvoiceCost { get; set; }
        public decimal? InvoiceExtendedCost { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ReceiverItem ReceiverItem { get; set; }
        public virtual VendorInvoice VendorInvoice { get; set; }
    }
}
