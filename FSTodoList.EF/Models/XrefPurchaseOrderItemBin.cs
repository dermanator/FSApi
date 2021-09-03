using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class XrefPurchaseOrderItemBin
    {
        public int PurchaseOrderItemBinId { get; set; }
        public int PurchaseOrderItemId { get; set; }
        public int BinId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual Bin Bin { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual PurchaseOrderItem PurchaseOrderItem { get; set; }
        public virtual User UpdatedBy { get; set; }
    }
}
