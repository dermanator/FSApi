using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class TypePurchaseOrder
    {
        public TypePurchaseOrder()
        {
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int PurchaseOrderTypeId { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
        public string DisplayValue { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
