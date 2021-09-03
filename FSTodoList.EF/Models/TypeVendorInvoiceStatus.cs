using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeVendorInvoiceStatus
    {
        public TypeVendorInvoiceStatus()
        {
            VendorInvoices = new HashSet<VendorInvoice>();
        }

        public int VendorInvoiceStatusId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<VendorInvoice> VendorInvoices { get; set; }
    }
}
