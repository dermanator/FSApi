using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypeShippingCode
    {
        public TypeShippingCode()
        {
            PurchaseOrders = new HashSet<PurchaseOrder>();
            Vendors = new HashSet<Vendor>();
        }

        public int ShippingCodeTypeId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
